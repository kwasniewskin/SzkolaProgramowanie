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

            //WypelnienieTabelBazaDanych();
            //DodanieJednostkiDoBazy("złoty polski", "zł", 1);
            //DodanieJednostkiDoBazy("dolar", "$", 1);
            //DodaniePrzelicznikaDoBazy();
        }

        private void WypelnienieTabelBazaDanych()
        {
            throw new NotImplementedException();
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

        private void DodaniePrzelicznikaDoBazy(int jednostkaZrodlowaId, int jednostkaDocelowaId)
        {
            Przeliczniki przeliczniki = new Przeliczniki();
            przeliczniki.JednostkaZrodlowaId = jednostkaZrodlowaId;
            przeliczniki.JednostkaDocelowaId = jednostkaDocelowaId;

            bazaDanych.Przeliczniki.Add(przeliczniki);
            bazaDanych.SaveChanges();
        }
        
    }
}
