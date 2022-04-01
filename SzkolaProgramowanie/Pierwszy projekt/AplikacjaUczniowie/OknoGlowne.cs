using AplikacjaUczniowie.BazaDanych.Context;
using AplikacjaUczniowie.BazaDanych.Model;
using AplikacjaUczniowie.InneKlasy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaUczniowie
{
    public partial class OknoGlowne : Form
    {
        private DataBaseContext bazaDanych;

        public OknoGlowne()
        {
            InitializeComponent();
            bazaDanych = new DataBaseContext();

            WyswietlUczniow();
            UzupelnijComboBoxKlasa();
        }

        #region Wyswietlanie
        private void WyswietlUczniow()
        {
            var listaUczniow = bazaDanych.Uczen
                .Include((Uczen u) => u.Klasa)
                .Select((Uczen u) => new UczniowieDoWyswietlenia()
                {
                    Imie = u.Imie,
                    Nazwisko = u.Nazwisko,
                    Klasa = u.Klasa.Nazwa,
                    RokUrodzenia = u.Rok_urodzenia
                })
                .ToList();

            dataGridViewListaUczniow.AutoGenerateColumns = true;
            dataGridViewListaUczniow.DataSource = listaUczniow;
        }

        private void WyswietlUczniow(string imie, string nazwisko, int idKlasy, int rokUrodzenia)
        {
            var listaUczniow = bazaDanych.Uczen
                .Include((Uczen u) => u.Klasa)
                .Where(u => u.Imie == imie && u.Nazwisko == nazwisko && u.KlasaId == idKlasy
                        && u.Rok_urodzenia == rokUrodzenia)
                .Select((Uczen u) => new UczniowieDoWyswietlenia()
                {
                    Imie = u.Imie,
                    Nazwisko = u.Nazwisko,
                    Klasa = u.Klasa.Nazwa,
                    RokUrodzenia = u.Rok_urodzenia
                })
                .ToList();

            dataGridViewListaUczniow.AutoGenerateColumns = true;
            dataGridViewListaUczniow.DataSource = listaUczniow;
        }
        #endregion

        #region Przyciski

        /*
        private void buttonSzukaj_Click(object sender, EventArgs e)
        {

            //var imie = textBoxImie.Text != "" ? textBoxImie.Text : true;

            string nazwisko = textBoxNazwisko.Text;
            int idKlasy = (comboBoxKlasa.SelectedItem as Klasa).Id;
            int rokUrodzenia = (int)numericUpDownRok.Value;

            //WyswietlUczniow(imie, nazwisko, idKlasy, rokUrodzenia);
        }
        */

        private void buttonDodajKlase_Click(object sender, EventArgs e)
        {
            string nazwaKlasy = "";

            OknoDodajKlase oknoDodajKlase = new OknoDodajKlase();
            oknoDodajKlase.NazwaKlasy = nazwaKlasy;

            if (oknoDodajKlase.ShowDialog() == DialogResult.OK)
            {
                nazwaKlasy = oknoDodajKlase.NazwaKlasy;
                DodajKlaseDoBazy(nazwaKlasy);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            OknoDodajUcznia oknoDodajUcznia = new OknoDodajUcznia();
            oknoDodajUcznia.Imie = "";
            oknoDodajUcznia.Nazwisko = "";
            oknoDodajUcznia.Rok = 0;

            if (oknoDodajUcznia.ShowDialog() == DialogResult.OK)
            {
                if (oknoDodajUcznia.Imie != "" && oknoDodajUcznia.Nazwisko != "" && oknoDodajUcznia.Rok != 0)
                {
                    DodajUczniaDoBazy(oknoDodajUcznia.Imie,
                                    oknoDodajUcznia.Nazwisko,
                                    oknoDodajUcznia.KlasaId,
                                    oknoDodajUcznia.Rok);
                }
            }
        }

        #endregion

        #region Dodawanie do bazy
        private void DodajKlaseDoBazy(string nazwaKlasy)
        {
            Klasa klasa = new Klasa();
            klasa.Nazwa = nazwaKlasy;

            bazaDanych.Klasa.Add(klasa);
            bazaDanych.SaveChanges();
        }

        private void DodajUczniaDoBazy(string imie, string nazwisko, int idKlasy, int rok)
        {
            Uczen uczen = new Uczen();
            uczen.Imie = imie;
            uczen.Nazwisko = nazwisko;
            uczen.KlasaId = idKlasy;
            uczen.Rok_urodzenia = rok;

            bazaDanych.Uczen.Add(uczen);
            bazaDanych.SaveChanges();

            WyswietlUczniow();
        }

        #endregion

        #region Inne Metody
        private void UzupelnijComboBoxKlasa()
        {
            var listaKlas = bazaDanych.Klasa.ToList();
            listaKlas.Insert(0, new Klasa()
            {
                Id = 0,
                Nazwa = "<wszystkie>"
            });

            comboBoxKlasa.DataSource = listaKlas;
            comboBoxKlasa.DisplayMember = "Nazwa";
        }
        #endregion
    }
}
