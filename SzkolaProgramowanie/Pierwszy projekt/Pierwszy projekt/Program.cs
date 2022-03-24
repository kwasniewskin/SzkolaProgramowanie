using System;
using System.Collections.Generic;

namespace Pierwszy_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string imie = "Jan";
            string nazwisko = "Kowalski";

            Console.WriteLine("witaj " + imie + " tutaj");
            Console.WriteLine("witaj {1} {0} tutaj", imie, nazwisko);
            Console.WriteLine($"witaj {imie} tutaj");

            Console.WriteLine("Prędkość to km\\h");
            Console.WriteLine(@"Prędkość to km\h");

            int liczba;
            Int32 liczba2 = new Int32();

            //int tablicaCpp[5];
            //tablicaCpp[2] = 6;

            int[] tablica = new int[5];
            int rozmiar = tablica.Length;
            tablica[1] = 6;


            //funkcja(tablicaCpp, 5);

            int a;
            a = 5;
            int b = a;
            b = 6;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);


            Osoba osobaPierwsza = new Osoba();
            osobaPierwsza.imie = "Jan";
            osobaPierwsza.nazwisko = "Kowalski";
            osobaPierwsza.wiek = 36;

            Osoba osobaDruga = new Osoba();
            osobaDruga.imie = "Paweł";
            osobaDruga.nazwisko = "Nowak";
            osobaDruga.wiek = 18;

            Osoba osobaTrzecia = osobaDruga;

            Osoba osobaCzwarta = osobaPierwsza;
            osobaCzwarta.imie = "Adam";
            osobaCzwarta.nazwisko = "Robak";
            osobaCzwarta.wiek = 15;


            Console.WriteLine($"Osoba 1: {osobaPierwsza.imie} {osobaPierwsza.nazwisko} wiek: {osobaPierwsza.wiek}");
            Console.WriteLine($"Osoba 2: {osobaDruga.imie} {osobaDruga.nazwisko} wiek: {osobaDruga.wiek}");
            Console.WriteLine($"Osoba 3: {osobaTrzecia.imie} {osobaTrzecia.nazwisko} wiek: {osobaTrzecia.wiek}");
            Console.WriteLine($"Osoba 4: {osobaCzwarta.imie} {osobaCzwarta.nazwisko} wiek: {osobaCzwarta.wiek}");


            Console.WriteLine("------------------------------");

            int x;
            x = 5;
            Console.WriteLine("X = " + x);
            Metoda1(x);
            Console.WriteLine("X = " + x);
            x = Metoda1_1(x);
            Console.WriteLine("X = " + x);
            Metoda1_2(ref x);
            Console.WriteLine("X = " + x);

            int y;
            Metoda1_3(out y);

            Osoba o = new Osoba();
            o.imie = "Jan";
            Console.WriteLine("o.imie = " + o.imie);
            Metoda2(o);
            Console.WriteLine("o.imie = " + o.imie);
        }

        //typ_zwracany nazwa_Funkcji (typ nazwa)

        static void Metoda1(int a)
        {
            Console.WriteLine("Metoda1 a= " + a);
            a++;
            Console.WriteLine("Metoda1 a= " + a);
        }

        static int Metoda1_1(int a)
        {
            Console.WriteLine("Metoda1_1 a= " + a);
            a++;
            Console.WriteLine("Metoda1_1 a= " + a);
            return a;
        }

        static void Metoda1_2(ref int a)
        {
            Console.WriteLine("Metoda1_2 a= " + a);
            a++;
            Console.WriteLine("Metoda1_2 a= " + a);
        }

        static void Metoda1_3(out int a)
        {
            a = 99;
            Console.WriteLine("Metoda1_3 a= " + a);
        }

        static void Metoda2(Osoba a)
        {
            Console.WriteLine("Metoda2 a.imie = " + a.imie);
            a.imie = "Adam";
            Console.WriteLine("Metoda2 a.imie = " + a.imie);
        }

    }



    //void funkcja(int[] tablica, int rozmiar)
}
