using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegaty.Zdarzenia;

namespace Delegaty
{
    class PorownajOsobyClass : IComparer<Osoba>
    {
        public int Compare(Osoba x, Osoba y)
        {
            return x.wiek > y.wiek ? 1 : (x.wiek == y.wiek ? 0 : -1);
        }
    }

    class Program
    {
        public static int PorownajOsoby(Osoba x, Osoba y)
        {
            return x.wiek > y.wiek ? 1 : (x.wiek == y.wiek ? 0 : -1);
        }

        static void Main(string[] args)
        {
            TestZdarzen test = new TestZdarzen();
            test.TestowanieZdarzen();

            Console.ReadLine();

            return;

            Delegaty delegaty = new Delegaty();
            //delegaty.TestDelegat();
            delegaty.GrupoweWywolanie();

            Console.ReadLine();

            List<int> listaInt = new List<int>();
            listaInt.Add(7);
            listaInt.Add(1);
            listaInt.Add(5);
            listaInt.Sort();
            foreach (int liczba in listaInt)
                Console.WriteLine(liczba);

            List<Osoba> listaOsoba = new List<Osoba>();
            listaOsoba.Add(new Osoba() { imie = "Jan", nazwisko = "Kowalski", wiek = 23 });
            listaOsoba.Add(new Osoba() { imie = "Paweł", nazwisko = "Nowak", wiek = 15 });
            listaOsoba.Add(new Osoba() { imie = "Adam", nazwisko = "Adamski", wiek = 20 });
            listaOsoba.Sort();
            listaOsoba.Sort(new PorownajOsobyClass());
            listaOsoba.Sort(PorownajOsoby);
            listaOsoba.Sort((x,y) => x.wiek > y.wiek ? 1 : (x.wiek == y.wiek ? 0 : -1));

            Sortowanie(listaOsoba, (o1, o2) => o1.wiek> o2.wiek);
        }

        public static void Sortowanie<T>(List<T> lista, Func<T, T, bool> sprawdzenie)
        {
            for (int i=0; i<lista.Count; i++)
                for (int j=0; j< lista.Count - 1; j++)
                {
                    //if (lista[j] > lista[j+1])
                    if (sprawdzenie(lista[j] ,lista[j+1]))
                    {
                        var osTmp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = osTmp;
                    }
                }
        }
    }
}
