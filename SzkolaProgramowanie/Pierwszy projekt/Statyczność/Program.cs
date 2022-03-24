using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statyczność
{
    class Utils
    {
        public static int ObliczCos()
        {
            return 0;
        }
    }

    static class A
    {
        private static int pole;
    }

    static class B //: A
    {
        private static int pole2;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Jan", "Kowalski", 30);
            Osoba o2 = new Osoba("Paweł", "Nowak", 40);
            Osoba o3 = new Osoba("Paweł", "Nowak", 40);
            Osoba o4 = new Osoba("Paweł", "Nowak", 40);
            Osoba o5 = new Osoba("Paweł", "Nowak", 40);
            Osoba o6 = new Osoba("Paweł", "Nowak", 40);
            //o1.imie = "Adam";
            Osoba.imie = "Adam";

            Console.WriteLine(Osoba.IleOsobUtworzono());

            double promien = 5;
            //Arytmetyka arytmetyka = new Arytmetyka();
            //Arytmetyka arytmetyka2 = new Arytmetyka();

            /*Math math = new Math();
            double x = math.Sqrt(9);*/

            double wynik = Math.Sqrt(9);
            //Arytmetyka.pi = 9;

            double poleKola = Arytmetyka.pi * promien * promien;
            double poleKola2 = Arytmetyka.ObliczPoleKola(promien);

            Console.ReadLine();
        }
    }
}
