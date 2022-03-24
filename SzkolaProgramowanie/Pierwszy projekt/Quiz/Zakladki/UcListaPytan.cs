using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Baza_danych.Dto;
using Baza_danych.Repository;
using Quiz.Okna_pomocnicze;

namespace Quiz.Zakladki
{
    public partial class UcListaPytan : UserControl
    {
        public IRepository Repository { get; set; }

        List<PytanieOdpowiedziQuiz> listaPytanOdpowiedzi = new List<PytanieOdpowiedziQuiz>();
        PytanieOdpowiedziQuiz aktualnePytanie;

        public UcListaPytan()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            int aktualnaPozycja = comboBoxListaPytan.SelectedIndex;

            comboBoxListaPytan.SelectedIndexChanged -= comboBoxListaPytan_SelectedIndexChanged;
            comboBoxListaPytan.Items.Clear();

            List<int> listaPytanId = Repository.ReadPytaniaIdList();
            foreach (int id in listaPytanId)
            {
                comboBoxListaPytan.Items.Add(id);
            }

            comboBoxListaPytan.SelectedIndexChanged += comboBoxListaPytan_SelectedIndexChanged;
            if (comboBoxListaPytan.Items.Count > 0 && aktualnaPozycja < 0)
                aktualnaPozycja++;
            comboBoxListaPytan.SelectedIndex = aktualnaPozycja;
        }

        private void comboBoxListaPytan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucWyswietlPytanie.WyswieltPytanie = null;

            if (comboBoxListaPytan.SelectedItem != null)
            {
                int.TryParse(comboBoxListaPytan.SelectedItem.ToString(), out int id);

                aktualnePytanie = PobierzPytanieOdpowiedz(listaPytanOdpowiedzi, id, true);
                ucWyswietlPytanie.WyswieltPytanie = aktualnePytanie;
            }
        }

        private void buttonUsunPytanie_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy usunąć pytanie?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<OdpowiedzDeleteDto> odpowiedzDeleteDtoLista = new List<OdpowiedzDeleteDto>();
                odpowiedzDeleteDtoLista.AddRange(aktualnePytanie.OdpowiedziLista.Select(odpowiedzQuiz => new OdpowiedzDeleteDto()
                {
                    Id = odpowiedzQuiz.OdpowiedzReadDto.Id
                }));
                Repository.DeleteOdpowiedz(odpowiedzDeleteDtoLista);

                Repository.DeletePytanie(new PytanieDeleteDto() { Id = aktualnePytanie.PytanieQuiz.PytanieReadDto.Id });
                listaPytanOdpowiedzi.Remove(aktualnePytanie);

                comboBoxListaPytan.SelectedIndexChanged -= comboBoxListaPytan_SelectedIndexChanged;

                int aktualnyIndex = comboBoxListaPytan.SelectedIndex;
                comboBoxListaPytan.Items.Remove(comboBoxListaPytan.SelectedItem);
                if (aktualnyIndex == comboBoxListaPytan.Items.Count)
                    aktualnyIndex--;
                comboBoxListaPytan.SelectedIndex = aktualnyIndex;

                comboBoxListaPytan.SelectedIndexChanged += comboBoxListaPytan_SelectedIndexChanged;
                comboBoxListaPytan_SelectedIndexChanged(null, null);
            }
        }

        public PytanieOdpowiedziQuiz PobierzPytanieOdpowiedz(List<PytanieOdpowiedziQuiz> lista, int idPytania, bool CzyZaznaczycPrawidlowe = false)
        {
            PytanieOdpowiedziQuiz pytanieOdpowiedziQuiz = lista.FirstOrDefault(poq => poq.PytanieQuiz.PytanieReadDto.Id == idPytania);
            if (pytanieOdpowiedziQuiz == null)
            {
                pytanieOdpowiedziQuiz = new PytanieOdpowiedziQuiz();
                lista.Add(pytanieOdpowiedziQuiz);

                pytanieOdpowiedziQuiz.PytanieQuiz = new PytanieQuiz();

                pytanieOdpowiedziQuiz.PytanieQuiz.PytanieReadDto = Repository.ReadPytanie(idPytania);
                pytanieOdpowiedziQuiz.PytanieQuiz.TextBoxPytanie = new TextBox()
                {
                    Text = pytanieOdpowiedziQuiz.PytanieQuiz.PytanieReadDto.TrescPytania,
                    Dock = DockStyle.Fill,
                    Multiline = true,
                    ScrollBars = ScrollBars.Both,
                    ReadOnly = true
                };

                pytanieOdpowiedziQuiz.OdpowiedziLista = Repository.ReadOdpowiedzi(idPytania).Select(odpowiedzDto => new OdpowiedzQuiz()
                {
                    OdpowiedzReadDto = odpowiedzDto,
                    CheckBoxOdpowiedzi = new CheckBox()
                    {
                        Text = odpowiedzDto.TrescOdpowiedzi,
                        Checked = CzyZaznaczycPrawidlowe && odpowiedzDto.CzyPoprawna,
                        Tag = odpowiedzDto.Id,
                        Enabled = false
                    }
                }).ToList();
            }
            return pytanieOdpowiedziQuiz;
        }

        private void buttonEdytujPytanie_Click(object sender, EventArgs e)
        {
            PytanieOdpowiedziQuiz pytanieOdpowiedziQuiz = PobierzPytanieOdpowiedz(new List<PytanieOdpowiedziQuiz>(), aktualnePytanie.PytanieQuiz.PytanieReadDto.Id, true);
            pytanieOdpowiedziQuiz.PytanieQuiz.TextBoxPytanie.ReadOnly = false;
            pytanieOdpowiedziQuiz.OdpowiedziLista.ForEach(odpowiedzi =>
            {
                odpowiedzi.CheckBoxOdpowiedzi.Enabled = true;
                odpowiedzi.CheckBoxOdpowiedzi.ThreeState = true;
            });

            OknoEdycjaPytania oknoEdycjaPytania = new OknoEdycjaPytania();
            oknoEdycjaPytania.PytanieOdpowiedziQuiz = pytanieOdpowiedziQuiz;
            oknoEdycjaPytania.Text = "Edycuja pytania";
            if (oknoEdycjaPytania.ShowDialog() == DialogResult.Yes)
            {
                PytanieUpdateDto updatePytanieDto = new PytanieUpdateDto()
                {
                    Id = pytanieOdpowiedziQuiz.PytanieQuiz.PytanieReadDto.Id,
                    TrescPytania = pytanieOdpowiedziQuiz.PytanieQuiz.TextBoxPytanie.Text
                };

                Repository.UpdatePytanie(updatePytanieDto);

                foreach (OdpowiedzQuiz odpowiedzQuiz in pytanieOdpowiedziQuiz.OdpowiedziLista)
                {
                    OdpowiedzUpdateDto odpowiedzUpdateDto = new OdpowiedzUpdateDto()
                    {
                        Id = odpowiedzQuiz.OdpowiedzReadDto.Id,
                        TrescOdpowiedzi = odpowiedzQuiz.OdpowiedzReadDto.TrescOdpowiedzi,
                        CzyPoprawna = odpowiedzQuiz.CheckBoxOdpowiedzi.Checked,
                        PytanieId = odpowiedzQuiz.OdpowiedzReadDto.PytanieId
                    };
                    if (!Repository.UpdateOdpowiedz(odpowiedzUpdateDto))
                    {
                        OdpowiedzCreateDto odpowiedz = new OdpowiedzCreateDto()
                        {
                            TrescOdpowiedzi = odpowiedzQuiz.OdpowiedzReadDto.TrescOdpowiedzi,
                            CzyPoprawna = odpowiedzQuiz.CheckBoxOdpowiedzi.Checked,
                            PytanieId = odpowiedzQuiz.OdpowiedzReadDto.PytanieId
                        };
                        Repository.CreateOdpowiedz(odpowiedz);
                    }
                }

                List<OdpowiedzDeleteDto> odpowiedzDeleteDtoList = new List<OdpowiedzDeleteDto>();
                odpowiedzDeleteDtoList.AddRange(oknoEdycjaPytania.ListaSkasowanychPozycji
                                                                .Where(odpowiedzQuiz => odpowiedzQuiz.OdpowiedzReadDto.Id > 0)
                                                                .Select(odpowiedzQuiz => new OdpowiedzDeleteDto()
                                                                {
                                                                    Id = odpowiedzQuiz.OdpowiedzReadDto.Id
                                                                }));
                Repository.DeleteOdpowiedz(odpowiedzDeleteDtoList);

                listaPytanOdpowiedzi.Remove(aktualnePytanie);
                comboBoxListaPytan_SelectedIndexChanged(null, null);
            }
        }

        private void buttonDodajPytanie_Click(object sender, EventArgs e)
        {
            PytanieOdpowiedziQuiz pytanieOdpowiedziQuiz = PobierzPytanieOdpowiedz(new List<PytanieOdpowiedziQuiz>(), -1, true);
            pytanieOdpowiedziQuiz.PytanieQuiz.TextBoxPytanie.ReadOnly = false;
            pytanieOdpowiedziQuiz.OdpowiedziLista.ForEach(odpowiedzi =>
            {
                odpowiedzi.CheckBoxOdpowiedzi.Enabled = true;
                odpowiedzi.CheckBoxOdpowiedzi.ThreeState = true;
            });

            OknoEdycjaPytania oknoEdycjaPytania = new OknoEdycjaPytania();
            oknoEdycjaPytania.PytanieOdpowiedziQuiz = pytanieOdpowiedziQuiz;
            oknoEdycjaPytania.Text = "Nowe pytanie";
            if (oknoEdycjaPytania.ShowDialog() == DialogResult.Yes)
            {
                PytanieCreateDto pytanieCreateDto = new PytanieCreateDto()
                {
                    TrescPytania = pytanieOdpowiedziQuiz.PytanieQuiz.TextBoxPytanie.Text
                };

                int idPytania = Repository.CreatePytanie(pytanieCreateDto);

                foreach (OdpowiedzQuiz odpowiedzQuiz in pytanieOdpowiedziQuiz.OdpowiedziLista)
                {
                    OdpowiedzCreateDto odpowiedz = new OdpowiedzCreateDto()
                    {
                        TrescOdpowiedzi = odpowiedzQuiz.OdpowiedzReadDto.TrescOdpowiedzi,
                        CzyPoprawna = odpowiedzQuiz.CheckBoxOdpowiedzi.Checked,
                        PytanieId = idPytania
                    };
                    Repository.CreateOdpowiedz(odpowiedz);
                }
            }

            RefreshData();
        }
    }
}

