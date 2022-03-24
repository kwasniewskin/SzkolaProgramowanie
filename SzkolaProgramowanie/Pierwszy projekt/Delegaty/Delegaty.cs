using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Delegaty
    {
        delegate int OperacjaDoWykonaniaDelegata(int a, int b);
        delegate void WyswieltWynikOperacjiDelegata(int w, char o);

        public void TestDelegat()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbę:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj operacje");
            char operacja = Console.ReadLine()[0];
            int wynik;

            //wersja pierwsza
            switch (operacja)
            {
                case '+':
                    wynik = Suma(x, y);
                    break;
                case '*':
                    wynik = Iloczyn(x, y);
                    break;
                default:
                    wynik = 0;
                    break;
            }
            WyswietlWynikOperacji(wynik, operacja);

            //wersja druga delegaty
            OperacjaDoWykonaniaDelegata operacjaDoWykonaniaDelegata;
            switch (operacja)
            {
                case '+':
                    //wynik = Suma(x, y);
                    operacjaDoWykonaniaDelegata = Suma;
                    break;
                case '*':
                    //wynik = Iloczyn(x, y);
                    operacjaDoWykonaniaDelegata = Iloczyn;
                    break;
                default:
                    //wynik = 0;
                    operacjaDoWykonaniaDelegata = null;
                    break;
            }
            if (operacjaDoWykonaniaDelegata != null)
            {
                wynik = operacjaDoWykonaniaDelegata(x, y);
            }
            else
            {
                wynik = 0;
            }
            WyswieltWynikOperacjiDelegata wyswieltWynikOperacjiDelegata = WyswietlWynikOperacji;
            wyswieltWynikOperacjiDelegata(wynik, operacja);

            //wersja trzecia akcje i funkcje
            Func<int, int, int> operacjaDoWykonaniaFunc;
            switch (operacja)
            {
                case '+':
                    //wynik = Suma(x, y);
                    operacjaDoWykonaniaFunc = Suma;
                    break;
                case '*':
                    //wynik = Iloczyn(x, y);
                    operacjaDoWykonaniaFunc = Iloczyn;
                    break;
                default:
                    //wynik = 0;
                    operacjaDoWykonaniaFunc = null;
                    break;
            }
            if (operacjaDoWykonaniaFunc != null)
            {
                wynik = operacjaDoWykonaniaFunc(x, y);
            }
            else
            {
                wynik = 0;
            }
            Action<int, char> wyswieltWynikOperacjiAkcja = WyswietlWynikOperacji;
            wyswieltWynikOperacjiAkcja(wynik, operacja);

            //wersja czwarta funkcje anonimowe
            Func<int, int, int> operacjaDoWykonaniaFunkcjaAnonimowa;
            switch (operacja)
            {
                case '+':
                    //wynik = Suma(x, y);
                    operacjaDoWykonaniaFunkcjaAnonimowa = delegate (int a, int b)
                                                                   {
                                                                       return a + b;
                                                                   };
                    break;
                case '*':
                    //wynik = Iloczyn(x, y);
                    operacjaDoWykonaniaFunkcjaAnonimowa = delegate (int a, int b)
                                                                    {
                                                                        return a * b;
                                                                    };
                    break;
                default:
                    //wynik = 0;
                    operacjaDoWykonaniaFunkcjaAnonimowa = null;
                    break;
            }
            if (operacjaDoWykonaniaFunkcjaAnonimowa != null)
            {
                wynik = operacjaDoWykonaniaFunkcjaAnonimowa(x, y);
            }
            else
            {
                wynik = 0;
            }
            Action<int, char> wyswieltWynikOperacjiFunkcjaAnonimowa = delegate (int w, char o)
                                                                                {
                                                                                    Console.WriteLine("Wynik operacji " + w + " to " + o);
                                                                                };
            wyswieltWynikOperacjiFunkcjaAnonimowa(wynik, operacja);

            //wersja piąta wyrażenia lambda
            Func<int, int, int> operacjaDoWykonaniaLambda;
            switch (operacja)
            {
                case '+':
                    //wynik = Suma(x, y);
                    operacjaDoWykonaniaLambda = (int a, int b) =>
                                                 {
                                                     return a + b;
                                                 };
                    break;
                case '*':
                    //wynik = Iloczyn(x, y);
                    operacjaDoWykonaniaLambda = (a, b) => a * b;
                    break;
                default:
                    //wynik = 0;
                    operacjaDoWykonaniaLambda = null;
                    break;
            }
            if (operacjaDoWykonaniaLambda != null)
            {
                wynik = operacjaDoWykonaniaLambda(x, y);
            }
            else
            {
                wynik = 0;
            }
            Action<int, char> wyswieltWynikOperacjiLambda = (w, o) => Console.WriteLine("Wynik operacji " + w + " to " + o);
            wyswieltWynikOperacjiLambda(wynik, operacja);


            //wersja szósta funkcja jako parametr

            switch (operacja)
            {
                case '+':
                    //WyswietlWynikOperacji(x, y, operacja, Suma);
                    WyswietlWynikOperacji(x, y, operacja, (a, b) => a + b);
                    break;
                case '*':
                    WyswietlWynikOperacji(x, y, operacja, Iloczyn);
                    break;
                default:
                    break;
            }
        }

        int Suma(int a, int b)
        {
            return a + b;
        }

        int Iloczyn(int a, int b)
        {
            return a * b;
        }

        void WyswietlWynikOperacji(int wynik, char operacja)
        {
            Console.WriteLine("Wynik operacji " + operacja + " to " + wynik);
        }

        void WyswietlWynikOperacji(int a, int b, char operacja, Func<int, int, int> funkcja)
        {
            int wynik;
            if (funkcja != null)
            {
                wynik = funkcja(a, b);
            }
            else
                wynik = 0;

            Console.WriteLine("Wynik operacji " + operacja + " to " + wynik);
        }


        

        public void GrupoweWywolanie()
        {
            Action delegataAkcji;

            delegataAkcji = Metoda1;
            delegataAkcji();

            delegataAkcji = Metoda2;
            delegataAkcji();

            delegataAkcji += Metoda1;
            delegataAkcji += Metoda2;
            delegataAkcji -= Metoda2;
            delegataAkcji();


        }

        void Metoda1()
        {
            Console.WriteLine("Teraz działa metoda 1");
        }

        void Metoda2()
        {
            Console.WriteLine("Teraz działa metoda 2");
        }
    }
}
