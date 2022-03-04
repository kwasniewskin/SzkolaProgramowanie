using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty.Zdarzenia
{
    class TestZdarzen
    {

        public void TestowanieZdarzen()
        {
            Liczba liczba = new Liczba();
            Obserwator obserwator = new Obserwator();
            Obserwator obserwator2 = new Obserwator();

            liczba.delegataZmianaPolaNumer += obserwator.Wyswietl;
            liczba.delegataZmianaPolaNumer += obserwator2.Wyswietl;

            //if (liczba.delegataZmianaPolaNumer != null)
            //    liczba.delegataZmianaPolaNumer(5);
            if (liczba.delegataZmianaPolaNumerStaryNowy!= null)
                liczba.delegataZmianaPolaNumerStaryNowy(5, 7);

            //liczba.delegat

            int liczbaUzytkownika;
            Console.WriteLine("Podaj liczbe:");
            string strLiczbaUzytkownika = Console.ReadLine();
            //liczbaUzytkownika = int.Parse(strLiczbaUzytkownika);
            if (int.TryParse(strLiczbaUzytkownika, out liczbaUzytkownika))
            {
                liczba.Numer = liczbaUzytkownika;
                //obserwator.Wyswietl(liczba.Numer);
            }

            liczba.Numer = 5;
            //obserwator.Wyswietl(liczba.Numer);


            liczba.Zeruj();
            //obserwator.Wyswietl(liczba.Numer);
        }

    }
}
