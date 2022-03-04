using Baza_danych.Repository;
using Quiz.Baza_danych.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Baza_danych.Dto;
using Quiz.Okna_pomocnicze;

namespace Quiz.Zakladki
{
    public partial class UcOknoQuiz : UserControl
    {
        public IRepository Repository;

        List<PytanieOdpowiedziQuiz> listaPytanOdpowiedzi;
        int aktualnePytanie = 0;

        TimeSpan czasOdliczania;

        public UcOknoQuiz()
        {
            InitializeComponent();
        }

        private void UcOknoQuiz_Load(object sender, EventArgs e)
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            if (!designMode)
                Tryb_PrzygotujQuiz();
        }

        #region Tryb - przygotowanie quiz

        private void Tryb_PrzygotujQuiz()
        {
            panelKoniguracja.Visible = true;

            buttonStart.Visible = false;
            buttonStop.Visible = false;
            labelOdliczanie.Visible = false;

            panelPytanie.Visible = false;
        }

        private void buttonLosujPytania_Click(object sender, EventArgs e)
        {
            int ilePytanLos = (int)numericUpDownIloscPytan.Value;
            List<PytanieReadDto> listaPytan = Repository.ReadRandomPytania(ilePytanLos);

            List<int> idPytanLista = listaPytan.Select(pytanie => pytanie.Id).ToList();

            List<OdpowiedzReadDto> listaOdpowiedzi = Repository.ReadOdpowiedzi(idPytanLista);

            listaPytanOdpowiedzi = new List<PytanieOdpowiedziQuiz>();

            foreach (PytanieReadDto pytanieReadDto in listaPytan)
            {
                PytanieOdpowiedziQuiz pytanieOdpowiedzi = new PytanieOdpowiedziQuiz();
                listaPytanOdpowiedzi.Add(pytanieOdpowiedzi);

                pytanieOdpowiedzi.PytanieQuiz = new PytanieQuiz()
                {
                    PytanieReadDto = pytanieReadDto,
                    TextBoxPytanie = new TextBox()
                    {
                        Text = pytanieReadDto.TrescPytania,
                        Dock = DockStyle.Fill,
                        Multiline = true,
                        ScrollBars = ScrollBars.Both,
                        ReadOnly = true
                    }
                };

                pytanieOdpowiedzi.PytanieQuiz.PytanieReadDto = pytanieReadDto;
                pytanieOdpowiedzi.OdpowiedziLista = listaOdpowiedzi.Where(odp => odp.PytanieId == pytanieReadDto.Id)
                                                                    .Select(odp => new OdpowiedzQuiz()
                                                                    {
                                                                        OdpowiedzReadDto = odp,
                                                                        CheckBoxOdpowiedzi = new CheckBox()
                                                                        {
                                                                            Text = odp.TrescOdpowiedzi
                                                                        }
                                                                    }).ToList();
            }

            buttonStart.Visible = true;
            panelPytanie.Visible = false;

            int liczbaSekund = (int)numericUpDownCzasNaPytanie.Value * listaPytanOdpowiedzi.Count + 1;
            czasOdliczania = new TimeSpan(0, 0, liczbaSekund);
        }

        #endregion

        #region Tryb - start quiz

        private void buttonStart_Click(object sender, EventArgs e)
        {
            panelKoniguracja.Visible = false;

            buttonStart.Visible = false;
            buttonStop.Visible = true;
            labelOdliczanie.Visible = true;

            panelPytanie.Visible = true;

            buttonNastepnePytanie.Enabled = listaPytanOdpowiedzi.Count > aktualnePytanie + 1;
            buttonPoprzedniePytanie.Enabled = aktualnePytanie > 0;

            PokazPytanie();

            timerZegar_Tick(null, null);
            timerZegar.Enabled = true;
        }

        private void buttonNastepnePytanie_Click(object sender, EventArgs e)
        {
            aktualnePytanie++;
            buttonNastepnePytanie.Enabled = listaPytanOdpowiedzi.Count > aktualnePytanie + 1;
            buttonPoprzedniePytanie.Enabled = aktualnePytanie > 0;

            PokazPytanie();
        }

        private void buttonPoprzedniePytanie_Click(object sender, EventArgs e)
        {
            aktualnePytanie--;
            buttonNastepnePytanie.Enabled = listaPytanOdpowiedzi.Count > aktualnePytanie + 1;
            buttonPoprzedniePytanie.Enabled = aktualnePytanie > 0;

            PokazPytanie();
        }

        private void PokazPytanie()
        {
            textBoxtrescPytania.Text = listaPytanOdpowiedzi[aktualnePytanie].PytanieQuiz.PytanieReadDto.TrescPytania;

            flowLayoutPanelOdpowiedzi.SuspendLayout();

            flowLayoutPanelOdpowiedzi.Controls.Clear();

            foreach (OdpowiedzQuiz odpowiedz in listaPytanOdpowiedzi[aktualnePytanie].OdpowiedziLista)
            {
                flowLayoutPanelOdpowiedzi.Controls.Add(odpowiedz.CheckBoxOdpowiedzi);
            }

            flowLayoutPanelOdpowiedzi.ResumeLayout(false);
            flowLayoutPanelOdpowiedzi.PerformLayout();
        }

        private void timerZegar_Tick(object sender, EventArgs e)
        {
            czasOdliczania = czasOdliczania.Subtract(new TimeSpan(0, 0, 1));
            labelOdliczanie.Text = czasOdliczania.ToString("c");
            if (czasOdliczania.TotalSeconds == 0)
            {
                timerZegar.Enabled = false;
                buttonStop_Click(null, null);
            }
            
        }
        #endregion

        #region Tryb - stop quiz

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Visible = false;
            panelKoniguracja.Visible = true;
            labelOdliczanie.Visible = false;
            timerZegar.Enabled = false;

            (int sumaPoprawnych, int sumaWszystkich) = SprawdzOdpowiedzi();

            MessageBox.Show($"Zdobyłeś {sumaPoprawnych} na {sumaWszystkich} punktów.");

            aktualnePytanie = 0;
            buttonNastepnePytanie.Enabled = listaPytanOdpowiedzi.Count > aktualnePytanie + 1;
            buttonPoprzedniePytanie.Enabled = aktualnePytanie > 0;
            PokazPytanie();
        }

        private (int, int) SprawdzOdpowiedzi()
        {
            int sumaPoprawnych = 0;
            int sumaWszystkich = 0;
            foreach (PytanieOdpowiedziQuiz pytanieOdpowiedzi in listaPytanOdpowiedzi)
            {
                foreach (OdpowiedzQuiz odpowiedz in pytanieOdpowiedzi.OdpowiedziLista)
                {
                    odpowiedz.CheckBoxOdpowiedzi.Enabled = false;

                    if (odpowiedz.OdpowiedzReadDto.CzyPoprawna)
                        odpowiedz.CheckBoxOdpowiedzi.BackColor = Color.Green;
                    else if (odpowiedz.CheckBoxOdpowiedzi.Checked)
                        odpowiedz.CheckBoxOdpowiedzi.BackColor = Color.Red;

                    if (odpowiedz.OdpowiedzReadDto.CzyPoprawna)
                        sumaWszystkich++;

                    if (odpowiedz.OdpowiedzReadDto.CzyPoprawna && odpowiedz.CheckBoxOdpowiedzi.Checked)
                    {
                        sumaPoprawnych++;
                    }
                }
            }

            return (sumaPoprawnych, sumaWszystkich);
        }

        #endregion
    }


}
