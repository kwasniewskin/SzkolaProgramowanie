using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Terminarz_siłownia.Baza_danych.Context;
using Terminarz_siłownia.Baza_danych.Model;

namespace Terminarz_siłownia
{
    public partial class OknoGlowne : Form
    {
        private DataBaseContext bazaDanych;

        public OknoGlowne()
        {
            InitializeComponent();

            bazaDanych = new DataBaseContext();

            //DodanieOsobDoBazy();

            LadowanieOsobDoComboBox();
        }

        private void LadowanieOsobDoComboBox()
        {
            /*
             select *
               from Osoby
             */
            List<Osoba> listaOsob = bazaDanych.Osoby.ToList();

        }

        private void DodanieOsobDoBazy()
        {
            Osoba osoba = new Osoba();
            osoba.Imie_Nazwisko = "Jan Kowalski";

            bazaDanych.Osoby.Add(osoba);

            osoba = new Osoba();
            osoba.Imie_Nazwisko = "Jacek Kiełbasa";

            bazaDanych.Osoby.Add(osoba);

            osoba = new Osoba();
            osoba.Imie_Nazwisko = "Igor Jajko";

            bazaDanych.Osoby.Add(osoba);

            bazaDanych.SaveChanges();
        }


    }
}
