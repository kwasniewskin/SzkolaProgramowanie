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
        }

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
