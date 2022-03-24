using Baza_danych.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz.Okna_pomocnicze
{
    public partial class OknoEdycjaPytania : Form
    {
        private PytanieOdpowiedziQuiz pytanieOdpowiedziQuiz;
        public PytanieOdpowiedziQuiz PytanieOdpowiedziQuiz { 
            get
            {
                return pytanieOdpowiedziQuiz;
            }
            set
            {
                pytanieOdpowiedziQuiz = value;
                ucWyswietlPytanie.WyswieltPytanie = value;
            }
        }

        public List<OdpowiedzQuiz> ListaSkasowanychPozycji = new List<OdpowiedzQuiz>();

        public OknoEdycjaPytania()
        {
            InitializeComponent();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void buttonDodajOdpowiedz_Click(object sender, EventArgs e)
        {
            OknoNowejOdpowiedzi oknoNowejOdpowiedzi = new OknoNowejOdpowiedzi();
            if (oknoNowejOdpowiedzi.ShowDialog() == DialogResult.OK)
            {
                pytanieOdpowiedziQuiz.OdpowiedziLista.Add(new OdpowiedzQuiz()
                {
                    CheckBoxOdpowiedzi = new CheckBox()
                    {
                        Text = oknoNowejOdpowiedzi.TrescOdpowiedzi,
                        Checked = oknoNowejOdpowiedzi.CzyPoprawna
                    },
                    OdpowiedzReadDto = new OdpowiedzReadDto()
                    {
                        Id = -1,
                        CzyPoprawna = oknoNowejOdpowiedzi.CzyPoprawna,
                        TrescOdpowiedzi = oknoNowejOdpowiedzi.TrescOdpowiedzi,
                        PytanieId = pytanieOdpowiedziQuiz.PytanieQuiz.PytanieReadDto.Id
                    }
                });
                ucWyswietlPytanie.WyswieltPytanie = pytanieOdpowiedziQuiz;
            }
        }

        private void buttonUsunOdpowiedzi_Click(object sender, EventArgs e)
        {
            ListaSkasowanychPozycji.AddRange(PytanieOdpowiedziQuiz.OdpowiedziLista.Where(odp => odp.CheckBoxOdpowiedzi.CheckState == CheckState.Indeterminate));

            pytanieOdpowiedziQuiz.OdpowiedziLista.RemoveAll(odp => odp.CheckBoxOdpowiedzi.CheckState == CheckState.Indeterminate);
            ucWyswietlPytanie.WyswieltPytanie = pytanieOdpowiedziQuiz;
        }
    }
}
