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

        private void WyswietlUczniow(string imie = "", string nazwisko = "", int idKlasy = 0, int rokUrodzenia = 0)
        {
            var listaUczniow = bazaDanych.Uczen
                .Include((Uczen u) => u.Klasa)
                .ToList();

            if (imie != "")
                listaUczniow = listaUczniow.Where(u => u.Imie == imie).ToList();

            if (nazwisko != "")
                listaUczniow = listaUczniow.Where(u => u.Nazwisko == nazwisko).ToList();

            if (idKlasy != 0)
                listaUczniow = listaUczniow.Where(u => u.KlasaId == idKlasy).ToList();

            if (rokUrodzenia != 0)
                listaUczniow = listaUczniow.Where(u => u.Rok_urodzenia == rokUrodzenia).ToList();

            var listaWynikowa = listaUczniow.Select(u => new UczniowieDoWyswietlenia()
            {
                Imie = u.Imie,
                Nazwisko = u.Nazwisko,
                Klasa = u.Klasa.Nazwa,
                RokUrodzenia = u.Rok_urodzenia
            })
                .ToList();

            dataGridViewListaUczniow.AutoGenerateColumns = true;
            dataGridViewListaUczniow.DataSource = listaWynikowa;

        }
        #endregion

        #region Przyciski

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewListaUczniow.SelectedRows)
            {
                UczniowieDoWyswietlenia uczenZaznaczony = row.DataBoundItem as UczniowieDoWyswietlenia;
                if (uczenZaznaczony != null)
                {
                    Uczen uczen = bazaDanych.Uczen
                        .Where(u => u.Imie == uczenZaznaczony.Imie
                            && u.Nazwisko == uczenZaznaczony.Nazwisko
                            && u.Klasa.Nazwa == uczenZaznaczony.Klasa
                            && u.Rok_urodzenia == uczenZaznaczony.RokUrodzenia)
                        .FirstOrDefault();

                    UsunUczniaZBazy(uczen);
                }
            }
            WyswietlUczniow();
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewListaUczniow.SelectedRows)
            {
                UczniowieDoWyswietlenia uczenZaznaczony = row.DataBoundItem as UczniowieDoWyswietlenia;
                if (uczenZaznaczony != null)
                {
                    Uczen uczen = bazaDanych.Uczen
                        .Where(u => u.Imie == uczenZaznaczony.Imie
                            && u.Nazwisko == uczenZaznaczony.Nazwisko
                            && u.Klasa.Nazwa == uczenZaznaczony.Klasa
                            && u.Rok_urodzenia == uczenZaznaczony.RokUrodzenia)
                        .FirstOrDefault();

                    OknoEdytuj oknoEdytuj = new OknoEdytuj(/*uczen*/);
                    if(oknoEdytuj.ShowDialog() == DialogResult.OK)
                    {
                        //EdytujUczniaWBazie(uczen,"imie","nazwisko",klasaId,"rok");
                    }
                }
            }
            WyswietlUczniow();
        }


        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            int idKlasy = (comboBoxKlasa.SelectedItem as Klasa).Id;
            int rokUrodzenia = (int)numericUpDownRok.Value;

            WyswietlUczniow(imie, nazwisko, idKlasy, rokUrodzenia);
        }
        

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

        #region Praca z Baza Danych

        private void EdytujUczniaWBazie(Uczen uczen, string imie, string nazwisko, int klasaid, int rok)
        {
            bazaDanych.Uczen.Find(uczen);

            if (imie != null)
                uczen.Imie = imie;
            if (nazwisko != null)
                uczen.Nazwisko = nazwisko;
            uczen.KlasaId = klasaid;
            uczen.Rok_urodzenia = rok;

            bazaDanych.Uczen.Update(uczen);
            bazaDanych.SaveChanges();
        }

        private void UsunUczniaZBazy(Uczen uczen)
        {
            bazaDanych.Uczen.Remove(uczen);
            bazaDanych.SaveChanges();
        }

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
