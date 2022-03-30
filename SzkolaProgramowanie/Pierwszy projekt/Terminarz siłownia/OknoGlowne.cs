using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Terminarz_siłownia.Baza_danych.Context;
using Terminarz_siłownia.Baza_danych.Model;
using Terminarz_siłownia.Inne_klasy;

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
            //DodanieKategoriiDoBazy();

            LadowanieOsobDoComboBox();
            LadowanieKategoriiDoComboBox();

            WyswietlCwiczeniaDlaOsoby();
        }

        private void LadowanieKategoriiDoComboBox()
        {
            List<Kategoria> listaKategorii = bazaDanych.Kategorie.ToList();
            comboBoxKategoria.DataSource = listaKategorii;
            comboBoxKategoria.DisplayMember = "NazwaKategorii";
        }

        private void LadowanieOsobDoComboBox()
        {
            /*
             select *
               from Osoby
             */
            List<Osoba> listaOsob = bazaDanych.Osoby.ToList();

            /*foreach (var osoba in listaOsob)
            {
                comboBoxOsoby.Items.Add(osoba.Imie_Nazwisko);
            }*/
            comboBoxOsoby.DataSource = listaOsob;
            comboBoxOsoby.DisplayMember = "Imie_Nazwisko";
        }

        private void buttonDodajCwiczenie_Click(object sender, EventArgs e)
        {
            Osoba os = comboBoxOsoby.SelectedItem as Osoba;

            Cwiczenie cw = new Cwiczenie()
            {
                IloscPowtorzen = (int)numericUpDownIloscPowtorzen.Value,
                DataCwiczenia = dateTimePickerDataCwiczenia.Value,
                OsobaId = os.Id,
                KategoriaId = (comboBoxKategoria.SelectedItem as Kategoria).Id
            };
            bazaDanych.Cwiczenia.Add(cw);
            bazaDanych.SaveChanges();
            MessageBox.Show("Dodano ćwiczenie do bazy");
            WyswietlCwiczeniaDlaOsoby();
        }

        private void WyswietlCwiczeniaDlaOsoby()
        {
            /*
             select k.NazwaKategorii,
                    c.IloscPowtorzen,
                    c.DataCwiczenia,
                    CZY_ZREALIZOWANE = case when c.DataCwiczenia < GETDATE() then true
                                            else false
                                       end
               from Cwiczenia c
               --join Osoba o on o.Id = c.OsobaId
               join Kategoria k on k.Id = c.KategoriaId
               where c.OsobaId = "wstawić konktetne id"  --o.Id 
            order by c.DataCwiczenia, k.NazwaKategorii, c.IloscPowtorzen
             
             */
            Osoba os = comboBoxOsoby.SelectedItem as Osoba;
            int idOsoby = os.Id;


            var listaWynikowa = bazaDanych
                .Cwiczenia
                .Include((Cwiczenie c) => c.Kategoria)
                .Where((Cwiczenie c) => /*return*/ c.OsobaId == idOsoby)
                .Select((Cwiczenie c) =>  new CwiczenieDoWyswietlenia()
                {
                    IloscPowtorzen = c.IloscPowtorzen,
                    DataCwiczenia = c.DataCwiczenia,
                    NazwaKategorii = c.Kategoria.NazwaKategorii,
                    CzyZrealizowane = c.DataCwiczenia < DateTime.Now

                })
                .OrderBy((CwiczenieDoWyswietlenia cw) => cw.DataCwiczenia)
                .ThenBy((CwiczenieDoWyswietlenia cw) => cw.NazwaKategorii)
                .ThenBy((CwiczenieDoWyswietlenia cw) => cw.IloscPowtorzen)
                .ToList();

            dataGridViewListaCwiczen.AutoGenerateColumns = true;  
            dataGridViewListaCwiczen.DataSource = listaWynikowa;

        }

        private void Testowanie()
         {
            /*
             select *
               from Cwiczenia c
             */
            List<Cwiczenie> wynik1 = bazaDanych.Cwiczenia.ToList();

            /*
             select *
               from Cwiczenia c
              where c.IloscPowtorzen > 5;
             
             */
            var wynik2 = bazaDanych.Cwiczenia
                                        .Where((Cwiczenie cw) => /*return */ cw.IloscPowtorzen > 5)
                                        .ToList();

            /*
             select *
               from Cwiczenia c, Kategoria k
              where c.KategoriaId = k.Id
             
            select *
              from Cwiczenia c
              join Kategoria k on k.Id = c.KategoriaId
             */

            var wynik3 = bazaDanych.Cwiczenia.Include(c => c.Kategoria).ToList();
            //var dana = wynik3[0].Kategoria.NazwaKategorii;

            /*
            select *
              from Cwiczenia c
              join Kategoria k on k.Id = c.KategoriaId
             where c.IloscPowtorzen > 5
              and k.NazwaKategorii = "Brzuszki"
             */

            var wynik4 = bazaDanych.Cwiczenia
                .Include(c => c.Kategoria)
                .Where(c => c.IloscPowtorzen > 5 && c.Kategoria.NazwaKategorii == "Brzuszki")
                .ToList();

            /*
             select os.*
              from Osoba os
              join Cwiczenia c on c.OsobaId = os.Id
            where c.IloscPowtorzen > 5
             */

            var wynik5 = bazaDanych.Osoby
                .Include(os => os.Cwiczenia)
                .Where(os => os.Cwiczenia.Exists(c => c.IloscPowtorzen>5))
                .ToList();

            /*
             select os.Imie_nazwisko, c.IloscPowtorzen, c.DataCwiczenia
               from Cwiczenia c
               join Osoba os
              where c.IloscPowtorzen > 5
             */

            List<Cwiczenie> listaStartowa = new List<Cwiczenie>();
            //uzupełnienie listy
            List<PlanTreningowy> listaWynikowa = new List<PlanTreningowy>();
            foreach (Cwiczenie cwiczenie in listaStartowa)
            {
                PlanTreningowy plan = new PlanTreningowy()
                {
                    imie = cwiczenie.Osoba.Imie_Nazwisko,
                    iloscPowtorzen = cwiczenie.IloscPowtorzen,
                    data = cwiczenie.DataCwiczenia
                };
                listaWynikowa.Add(plan);
            }

            List<PlanTreningowy> wynik6 = bazaDanych.Cwiczenia.Include(c => c.Osoba)
                .Where(c => c.IloscPowtorzen > 5)
                .Select(c => new PlanTreningowy()
                {
                    imie = c.Osoba.Imie_Nazwisko,
                    iloscPowtorzen = c.IloscPowtorzen,
                    data = c.DataCwiczenia
                })
                .ToList();

            //---------------------------------------------------------------------------
            Cwiczenie c = new Cwiczenie();
            c.IloscPowtorzen = 5;

            Kategoria k = new Kategoria();
            k.NazwaKategorii = "XYZ";

            c.Kategoria = k;

            Kategoria k2 = c.Kategoria;

            Console.WriteLine(k2.NazwaKategorii);
            Console.WriteLine(c.Kategoria.NazwaKategorii.Length);

            List<Cwiczenie> listaStart = new List<Cwiczenie>();
            listaStart.Add(c);
            listaStart.Add(new Cwiczenie());

            var wynik10 = listaStart.Where(cc => cc.IloscPowtorzen > 5);

            List<Cwiczenie> wynik11 = new List<Cwiczenie>();
            foreach (Cwiczenie cwiczenie in listaStart)
            {
                if (cwiczenie.IloscPowtorzen > 5)
                    wynik11.Add(cwiczenie);
            }

            wynik10 = wynik11;
            var wyniik12 = wynik10.FirstOrDefault();

            var wynik12 = listaStart.Where(cc => cc.IloscPowtorzen > 5).FirstOrDefault().IloscPowtorzen;

            var wynik13 = listaStart.FirstOrDefault().IloscPowtorzen;

            Cwiczenie cc = listaStart.FirstOrDefault();
            //Cwiczenie c3 = null;
            int? ile = null;
            if (cc != null)
                ile = c.IloscPowtorzen;

            int? ile2 = listaStart.FirstOrDefault()?.IloscPowtorzen;

         }

        #region Uzupełnienie bazy danych 

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

        private void DodanieKategoriiDoBazy()
        {
            Kategoria kat = new Kategoria()
            {
                NazwaKategorii = "Brzuszki"
            };
            bazaDanych.Kategorie.Add(kat);

            kat = new Kategoria()
            {
                NazwaKategorii = "Przysiady"
            };
            bazaDanych.Kategorie.Add(kat);

            kat = new Kategoria()
            {
                NazwaKategorii = "Zwis na drążku"
            };
            bazaDanych.Kategorie.Add(kat);

            bazaDanych.SaveChanges();
        }

        #endregion

        private void comboBoxOsoby_SelectedValueChanged(object sender, EventArgs e)
        {
            WyswietlCwiczeniaDlaOsoby();
        }
    }

    class PlanTreningowy
    {
        public string imie;
        public int iloscPowtorzen;
        public DateTime data;
    }
}
