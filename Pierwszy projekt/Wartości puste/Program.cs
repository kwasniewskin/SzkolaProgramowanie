using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wartości_puste
{
    static class Utils
    {
        public static int ToInt(this int? dana)
        {
            if (dana != null)
                return dana.Value;
            else
                return 0;
        }

        public static int IleDuzychLiter(this string lancuch)
        {
            int iloscDuzychliter = 0;
            for (int i = 0; i < lancuch.Length; i++)
                if (lancuch[i] >= 'A' && lancuch[i] <= 'Z')
                    iloscDuzychliter++;

            return iloscDuzychliter;
        }
    }

    class Program
    {
        

        class OsobaPotomna : Osoba
        {
            public OsobaPotomna() : base("", "", null)
            {

            }

            public void Metoda()
            {

            }
        }

        static void Main(string[] args)
        {
            string zdanie;
            Console.WriteLine("Podaj zdanie do zbadania:");
            zdanie = Console.ReadLine();

            int iloscDuzychliter = Utils.IleDuzychLiter(zdanie);
            iloscDuzychliter = zdanie.IleDuzychLiter();

            Console.WriteLine("Dużych liter jest: " + iloscDuzychliter);

            Console.ReadLine();
            return;


            int? zmienna = 5;
            zmienna = null;
            int wynik = 0;
            if (zmienna != null)
                wynik = zmienna.Value * 2;
            else
                wynik = 0 * 2;

            //wynik = Utils.ToInt(zmienna) * 2;
            wynik = zmienna.ToInt() * 2;

            OsobaPotomna o1;
            o1 = null;
            if (o1 != null)
            {

            }
            if (zmienna != null)
            {

            }
            zmienna = null;


            Osoba osoba1 = new Osoba("Jan", "Kowalski", 30);
            Osoba osoba2 = new Osoba("Paweł", "Kowalski", null);

            Osoba osoba3 = null;

            if (osoba3 != null)
            {
                osoba3.nazwisko = "Nowak";
            }

            Metoda(osoba1);
            Metoda(osoba3);
            Metoda(null);

            int x = 5;
            Metoda2(5);
            Metoda2(x);
            Metoda2(null);
        }

        static void Metoda(Osoba o)
        {
            if (o != null)
                o.nazwisko = "Nowak";
        }

        static void Metoda2(int? x)
        {
            if (x != null)
                x = 2;
        }
    }
}
