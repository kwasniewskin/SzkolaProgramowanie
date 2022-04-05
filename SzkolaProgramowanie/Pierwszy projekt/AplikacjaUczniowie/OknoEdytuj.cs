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
                string klasaNazwa = comboBoxKlasa.SelectedItem.ToString();
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

        public OknoEdytuj(/*Uczen uczen*/)
        {
            InitializeComponent();
            bazaDanych = new DataBaseContext();

            LadowanieKlasDoComboBoxa();
            LadowanieDanychEdytowanegoUcznia();
        }

        private void LadowanieDanychEdytowanegoUcznia()
        {
            //textBoxImie.Text = bazaDanych
        }

        private void LadowanieKlasDoComboBoxa()
        {
            var nazwyKlas = bazaDanych.Klasa
                    .ToList();

            comboBoxKlasa.DataSource = nazwyKlas;
            comboBoxKlasa.DisplayMember = "Nazwa";
        }

        private void buttonZaktualizuj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
