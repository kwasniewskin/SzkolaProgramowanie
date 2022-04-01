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
    public partial class OknoDodajUcznia : Form
    {
        private DataBaseContext bazaDanych;

        public string Imie {
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

        public int KlasaId
        {
            get
            {
                Klasa klasa = comboBoxKlasa.SelectedItem as Klasa;
                return klasa.Id;
            }
            set
            {
                comboBoxKlasa.SelectedItem = value;
            } 
        }

        public int Rok {
            get
            {
                return (int)numericUpDownRokUrodzenia.Value;
            }
            set
            {
                numericUpDownRokUrodzenia.Value = value;
            }
        }

        public OknoDodajUcznia()
        {
            InitializeComponent();
            bazaDanych = new DataBaseContext();

            LadowanieKlasDoComboBoxa();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LadowanieKlasDoComboBoxa()
        {
            var nazwyKlas = bazaDanych.Klasa
                    .ToList();

            comboBoxKlasa.DataSource = nazwyKlas;
            comboBoxKlasa.DisplayMember = "Nazwa";
        }
    }
}
