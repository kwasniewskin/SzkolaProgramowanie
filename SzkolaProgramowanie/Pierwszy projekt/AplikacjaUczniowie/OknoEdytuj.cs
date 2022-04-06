using AplikacjaUczniowie.BazaDanych.Context;
using AplikacjaUczniowie.BazaDanych.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplikacjaUczniowie
{
    public partial class OknoEdytuj : Form
    {
        private DataBaseContext bazaDanych;

        public string Imie
        {
            get
            {
                return textBoxImie.Text;
            }
            set
            {
                textBoxImie.Text = value;
            }
        }

        public string Nazwisko
        {
            get
            {
                return textBoxNazwisko.Text;
            }
            set
            {
                textBoxNazwisko.Text = value;
            }
        }

        public string KlasaNazwa
        {
            get
            {
                int Zaznaczony = comboBoxKlasa.SelectedIndex +1;

                string klasaNazwa = bazaDanych.Klasa
                    .Where(k => k.Id == Zaznaczony)
                    .Select(k => k.Nazwa)
                    .FirstOrDefault();

                return klasaNazwa;
            }
            set
            {
                comboBoxKlasa.SelectedItem = value;
            }
        }

        public int Rok
        {
            get
            {
                return (int)numericUpDownRok.Value;
            }
            set
            {
                numericUpDownRok.Value = value;
            }
        }

        public OknoEdytuj()
        {
            InitializeComponent();
        }

        public OknoEdytuj(List<object> DaneUczniaOknoGlowne)
        {
            InitializeComponent();
            bazaDanych = new DataBaseContext();

            Imie = (string)DaneUczniaOknoGlowne[0];
            Nazwisko = (string)DaneUczniaOknoGlowne[1];
            KlasaNazwa = (string)DaneUczniaOknoGlowne[2];
            Rok = (int)DaneUczniaOknoGlowne[3];

            LadowanieDanychEdytowanegoUcznia();
            LadowanieKlasDoComboBoxa((string)DaneUczniaOknoGlowne[2]);
        }

        private void LadowanieDanychEdytowanegoUcznia()
        {
            textBoxImie.Text = Imie;
            textBoxNazwisko.Text = Nazwisko;
            numericUpDownRok.Value = Rok;
        }

        private void LadowanieKlasDoComboBoxa(string NazwaKlasy)
        {
            //Lista jest numerowana od 0 nie tak jak indexy od 1 wiec w kodzie pojawia sie
            // +1 oraz -1
            var Klasy = bazaDanych.Klasa
                    .ToList();

            comboBoxKlasa.DataSource = Klasy;
            comboBoxKlasa.DisplayMember = "Nazwa";

            comboBoxKlasa.SelectedIndex = bazaDanych.Klasa
                .Where(k => k.Nazwa == NazwaKlasy)
                .Select(k => k.Id)
                .FirstOrDefault()
                -1;
        }

        private void buttonZaktualizuj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
