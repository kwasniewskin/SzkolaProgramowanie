using System;
using System.Collections.Generic;
using System.Linq;
using Test_bazy_danych.Context;
using Test_bazy_danych.Model;
using Microsoft.EntityFrameworkCore;

namespace Test_bazy_danych
{
    class Program
    {
        static void Main(string[] args)
        {
            //CrerateOsoba();

            //CreateList();

            //ReadOsoba();

            //UpdateOsoba();

            //DeleteOsoba();


            //CreatePlecLista();

            //UpdateOsobyPlecId();

            SqlContext sqlContext = new SqlContext();

            //Osoba osoba = sqlContext.Osoby.Include(o => o.Plec).FirstOrDefault(o => o.Id == 1);

            /*
            select *
              from Plec p
              join Osoby o on o.PelcId = p.Id
             where o.Nazwisko = "Kowal"


            select *
              from Plec p, Osoby o 
             where o.PelcId = p.Id
               and o.Nazwisko = "Kowal"


            select *
              from Osoby o 
              join Plec p on p.Id = o.PelcId
             where o.Nazwisko = "Kowal"
            */

            List<Osoba> wynik = sqlContext.Osoby.Include((Osoba o) => o.Plec).Where(o=> o.Nazwisko == "Kowal").ToList();

            //Plec plecM = sqlContext.Plec.Include(p=> p.osoby).Where(p => p.osoby.Count > 2).FirstOrDefault();

            //Osoba osoba = sqlContext.Osoby.FirstOrDefault(o => o.Id == 1);

            //sqlContext.Entry(osoba).Collection(o => o.Plec).Load();

            sqlContext.Dispose();
        }

        private static void UpdateOsobyPlecId()
        {
            SqlContext sqlContext = new SqlContext();

            //select * from Osoby
            List<Osoba> listaOsob = sqlContext.Osoby.ToList();
            foreach (Osoba osoba in listaOsob)
            {
                if (osoba.Id == 1)
                    osoba.PlecId = 1;
                if (osoba.Id == 2)
                    osoba.PlecId = 2;
            }
            sqlContext.SaveChanges();


            sqlContext.Dispose();
        }

        private static void CreatePlecLista()
        {
            SqlContext sqlContext = new SqlContext();

            List<Plec> listaPlec = new List<Plec>()
            {
                new Plec()
                {
                    Skrot = 'K',
                    Nazwa = "Kobieta"
                },
                new Plec()
                {
                    Skrot = 'M',
                    Nazwa = "Mężczyzna"
                }
            };
            sqlContext.Plec.AddRange(listaPlec);
            sqlContext.SaveChanges();

            sqlContext.Dispose();
        }

        private static void DeleteOsoba()
        {
            SqlContext sqlContext = new SqlContext();

            Osoba osoba = sqlContext.Osoby.FirstOrDefault(os => os.Id == 3);
            if (osoba != null)
            {
                sqlContext.Osoby.Remove(osoba);
                sqlContext.SaveChanges();
            }

            sqlContext.Dispose();
        }

        private static void UpdateOsoba()
        {
            SqlContext sqlContext = new SqlContext();

            /*
             update Osoba
                set imie = "Karolina"
              where id = 1
             */

            /*
            select *
              from Osoby
             where id = 1
            */

            Osoba osoba = sqlContext.Osoby.FirstOrDefault(os => os.Id == 1);
            if (osoba != null)
            {
                osoba.Imie = "Karolina";
                sqlContext.SaveChanges();
            }

            sqlContext.Dispose();
        }

        private static void ReadOsoba()
        {
            SqlContext sqlContext = new SqlContext();

            /*
            select *
            from Osoby
            where id >=2
            order by imie
            */
            List<Osoba> listaOsob = sqlContext.Osoby.Where((Osoba os) => os.Id >= 2).OrderBy(os => os.Imie).ToList();
            foreach (Osoba osoba in listaOsob)
                Console.WriteLine(osoba.Id + "    " + osoba.Imie + " " + osoba.Nazwisko);

            sqlContext.Dispose();

            Console.ReadLine();
        }

        private static void CreateList()
        {
            SqlContext sqlContext = new SqlContext();

            List<Osoba> listaOsob = new List<Osoba>()
            {
                new Osoba()
                {
                    Imie = "Paweł",
                    Nazwisko = "Nowak"
                },
                new Osoba()
                {
                    Imie = "Jan",
                    Nazwisko = "Kowal"
                }
            };

            sqlContext.Osoby.AddRange(listaOsob);
            sqlContext.SaveChanges();

            sqlContext.Dispose();
        }

        private static void CrerateOsoba()
        {
            SqlContext sqlContext = new SqlContext();

            Osoba osoba = new Osoba()
            {
                Imie = "Ewa",
                Nazwisko = "Kowalczyk"
            };
            sqlContext.Osoby.Add(osoba);
            sqlContext.SaveChanges();

            sqlContext.Dispose();
        }
    }
}
