using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Przykladowa
    {
        public int x;
    }

    class Kolekcje
    {
        public static void PracaNaTablicach()
        {
            //int tablica[5];

            int[] tablicaLiczb;
            tablicaLiczb = new int[5];

            tablicaLiczb[1] = 77;
            int x = tablicaLiczb.Length;

            Przykladowa[] tablicaObiektow;
            tablicaObiektow = new Przykladowa[5];

            tablicaObiektow[1] = new Przykladowa();
            tablicaObiektow[1].x = 99;
            int dana = tablicaObiektow[1].x;

            //----------------------------------------------------------
            int[] tablicaLiczbCalkowitych = new int[6];

            Random liczbaLosowa = new Random();

            for (int i = 0; i < tablicaLiczbCalkowitych.Length; i++)
            {
                tablicaLiczbCalkowitych[i] = liczbaLosowa.Next(10, 100);
            }

            for (int i = 0; i < tablicaLiczbCalkowitych.Length; i++)
            {
                Console.WriteLine(tablicaLiczbCalkowitych[i]);
            }

            Console.WriteLine("-----------------------");
            foreach (int liczbaCalkowita in tablicaLiczbCalkowitych)
            {
                Console.WriteLine(liczbaCalkowita);
            }

            Console.WriteLine("-----------------------");
            foreach (var liczbaCalkowita in tablicaLiczbCalkowitych)
            {
                Console.WriteLine(liczbaCalkowita);
            }
        }

        public static void PierwszePodejscieDoList()
        {
            Console.WriteLine("Dane dla listy:");

            Random liczbaLosowa = new Random();

            List<int> listaLiczbCalkowitych = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                listaLiczbCalkowitych.Add(liczbaLosowa.Next(0, 100));
            }

            /*for (int i = 0; i < listaLiczbCalkowitych.Count; i++)
            {
                Console.WriteLine(listaLiczbCalkowitych[i]);
            }*/

            foreach (int liczbaCalkowita in listaLiczbCalkowitych)
            {
                Console.WriteLine(liczbaCalkowita);
            }

            /*int min = listaLiczbCalkowitych[0];
            for (int i = 0; i < listaLiczbCalkowitych.Count; i++)
            {
                if (min > listaLiczbCalkowitych[i])
                    min = listaLiczbCalkowitych[i];
            }*/

            int min = listaLiczbCalkowitych.Min();
            Console.WriteLine("Najmniejsza liczba w liście to: " + min);

            double srednia = listaLiczbCalkowitych.Average();
            Console.WriteLine("Średnia liczb: " + srednia);

            List<int> nowaLista = new List<int>();
            foreach (int liczba in listaLiczbCalkowitych)
            {
                if (liczba < srednia)
                    nowaLista.Add(liczba);
            }

            nowaLista = listaLiczbCalkowitych.Where(liczba => liczba < srednia).ToList();
            nowaLista.Sort();

            foreach (int liczbaCalkowita in nowaLista)
            {
                Console.WriteLine(liczbaCalkowita);
            }

        }

        public static void ListaOsob()
        {
            /*
            Osoba[] tablicaOsob = new Osoba[5];
            tablicaOsob[0] = new Osoba("Jan", "Kowalski", 30);
            */

            List<Osoba> listaOsob = new List<Osoba>();
            listaOsob.Add(new Osoba("Jan", "Kowalski", 30));
            listaOsob.Add(new Osoba("Paweł", "Nowak", 66));
            listaOsob.Add(new Osoba("Marcin", "Miły", 10));
            listaOsob.Add(new Osoba("Anna", "Kowalski", 20));
            listaOsob.Add(new Osoba("Maja", "Sowa", 12));

            Console.WriteLine("Lista osób:");
            foreach (Osoba osoba in listaOsob)
            {
                Console.WriteLine(osoba);
            }

            List<Osoba> lista = new List<Osoba>();
            var listaWynikowa = Sortowanie(lista, SprawdzOsoby);
            listaWynikowa = Sortowanie(lista, (o1, o2) => o1.wiek < o2.wiek);

            

            List<int> l1 = new List<int>();
            var listaIntWynikowa = Sortowanie(l1, (o1, o2) => o1 > o2);
            //List<Ulamek> l2;
             //var listaWynikowaUlamek = Sortowanie(l2, (u1, u2) => u1.licznik * u2.mianownik > u2.licznik * u1.mianownik);

            var suma = lista.Sum(o => o.wiek);
            suma = Suma(lista, o => o.wiek);
            //suma = Suma(l2, u => u.licznik / u.mianownik);

            List<Osoba> listaPosortowana = listaOsob.OrderBy(osoba => /*return*/ osoba.nazwisko).ToList();
            Console.WriteLine();
            Console.WriteLine("Lista osób posortowana po nazwisku:");
            foreach (Osoba osoba in listaPosortowana)
            {
                Console.WriteLine(osoba);
            }

            listaPosortowana = listaOsob.OrderBy(osoba => osoba.nazwisko).ThenByDescending(osoba => osoba.wiek).ToList();
            Console.WriteLine();
            Console.WriteLine("Lista osób posortowana po nazwisku i wieku:");
            foreach (Osoba osoba in listaPosortowana)
            {
                Console.WriteLine(osoba);
            }
        }

        static int Suma<T>(List<T> lista, Func<T, int> metroda)
        {
            int suma = 0;
            foreach(T element in lista)
            {
                suma = suma + metroda(element);
            }
            return suma;
        }

        static bool SprawdzOsoby(Osoba o1, Osoba o2)
        {
            return o1.wiek > o2.wiek;
        }

        static List<T> Sortowanie<T>(List<T> lista, Func<T, T, bool> metodaSprawdzajaca)
        {
            List<T> listaWynikowa = new List<T>(lista);
            for (int i = 0; i < lista.Count; i++)
                for (int j = 0; j < lista.Count - 1; j++)
                    if (metodaSprawdzajaca(listaWynikowa[j], listaWynikowa[j + 1]))
                    {
                        T tmp = listaWynikowa[j];
                        listaWynikowa[j] = listaWynikowa[j + 1];
                        listaWynikowa[j + 1] = tmp;
                    }
            return listaWynikowa;
        }

    }
}
