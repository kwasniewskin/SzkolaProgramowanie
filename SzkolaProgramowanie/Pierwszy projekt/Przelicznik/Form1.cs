using Microsoft.EntityFrameworkCore;
using Przelicznik.BazaDanych.Context;
using Przelicznik.BazaDanych.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przelicznik
{
    public partial class FormPrzelicznik : Form
    {
        private DataBaseContext bazaDanych;

        public FormPrzelicznik()
        {
            InitializeComponent();

            bazaDanych = new DataBaseContext();

            //UzupelnianieBazyDanych();

            LadowanieRodzajowDoComboBox();
            LadowanieJednostekZrodlowychDlaRodzaju();
            LadowanieJednostekDocelowychDlaRodzaju();
        }

        private void buttonPrzelicz_Click(object sender, EventArgs e)
        {
            double wartosc = (double)numericUpDownWartosc.Value;

            Jednostki jednostkaZrodlowa = comboBoxJednostkaZrodlowa.SelectedItem as Jednostki;
            int jednostkaZrodlowaId = jednostkaZrodlowa.Id;

            Jednostki jednostkaDocelowa = comboBoxJednostkaDocelowa.SelectedItem as Jednostki;
            int jednostkaDocelowaId = jednostkaDocelowa.Id;

            double przelicznik;

            if(jednostkaZrodlowaId == jednostkaDocelowaId)
            {
                przelicznik = 1;
            }
            else
            {
                przelicznik = bazaDanych.Przeliczniki
                    .Where((Przeliczniki p) => p.JednostkaZrodlowaId == jednostkaZrodlowaId &&
                                                p.JednostkaDocelowaId == jednostkaDocelowaId)
                    .Select((Przeliczniki p) => p.Wartosc)
                    .FirstOrDefault();
            }

            string znak = bazaDanych.Jednostki
                .Where((Jednostki j) => j.Id == jednostkaDocelowaId)
                .Select((Jednostki j) => j.Symbol)
                .FirstOrDefault();

            double wynik = wartosc * przelicznik;

            labelWynik.Text = "Wynik: " + wynik.ToString() + " " + znak;
        }

        #region Ladodwanie danych do combobox
        private void LadowanieJednostekDocelowychDlaRodzaju()
        {
            Rodzaj rodzaj = comboBoxRodzaj.SelectedItem as Rodzaj;
            int rodzajId = rodzaj.Id;

            var listaWynikowa = bazaDanych.Jednostki
                .Where((Jednostki j) => j.RodzajId == rodzajId)
                .ToList();

            comboBoxJednostkaDocelowa.DataSource = listaWynikowa;
            comboBoxJednostkaDocelowa.DisplayMember = "Nazwa";
        }

        private void LadowanieJednostekZrodlowychDlaRodzaju()
        {
            Rodzaj rodzaj = comboBoxRodzaj.SelectedItem as Rodzaj;
            int rodzajId = rodzaj.Id;

            var listaWynikowa = bazaDanych.Jednostki
                .Where((Jednostki j) => j.RodzajId == rodzajId)
                .ToList();

            comboBoxJednostkaZrodlowa.DataSource = listaWynikowa;
            comboBoxJednostkaZrodlowa.DisplayMember = "Nazwa";
        }

        private void LadowanieRodzajowDoComboBox()
        {
            List<Rodzaj> rodzaj = bazaDanych.Rodzaj.ToList();
            comboBoxRodzaj.DataSource = rodzaj;
            comboBoxRodzaj.DisplayMember = "Nazwa";
        }
        #endregion

        #region Uzupelnianie Bazy Danych
        private void UzupelnianieBazyDanych()
        {
            DodanieRodzajuDoBazy("Masa");
            DodanieJednostkiDoBazy("kilogram", "kg", 2);
            DodanieJednostkiDoBazy("gram", "g", 2);
            DodaniePrzelicznikaDoBazy(3, 4, 1000);
            DodaniePrzelicznikaDoBazy(4, 3, 0.001);

            DodanieRodzajuDoBazy("Waluta");
            DodanieJednostkiDoBazy("dolar", "$", 1);
            DodanieJednostkiDoBazy("złoty polski", "zł", 1);
            DodaniePrzelicznikaDoBazy(2, 1, 0.24);
            DodaniePrzelicznikaDoBazy(2, 1, 0.24);
        }

        private void DodanieRodzajuDoBazy(string nazwa)
        {
            Rodzaj rodzaj = new Rodzaj();
            rodzaj.Nazwa = nazwa;

            bazaDanych.Rodzaj.Add(rodzaj);
            bazaDanych.SaveChanges();
        }

        private void DodanieJednostkiDoBazy(string nazwa, string symbol, int rodzajId)
        {
            Jednostki jednostki = new Jednostki();
            jednostki.Nazwa = nazwa;
            jednostki.Symbol = symbol;
            jednostki.RodzajId = rodzajId;

            bazaDanych.Jednostki.Add(jednostki);
            bazaDanych.SaveChanges();
        }

        private void DodaniePrzelicznikaDoBazy(int jednostkaZrodlowaId, int jednostkaDocelowaId, double wartosc)
        {
            Przeliczniki przeliczniki = new Przeliczniki();
            przeliczniki.JednostkaZrodlowaId = jednostkaZrodlowaId;
            przeliczniki.JednostkaDocelowaId = jednostkaDocelowaId;
            przeliczniki.Wartosc = wartosc;

            bazaDanych.Przeliczniki.Add(przeliczniki);
            bazaDanych.SaveChanges();
        }

        #endregion

    }
}
