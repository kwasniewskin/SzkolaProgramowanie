using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsługa_błedów
{
    class Program
    {
        static int? Ilotraz(int x, int y)
        {
            if (y != 0)
                return x / y;
            return null;

        }

        static int? Metoda()
        {

            //
            return null;

        }

        static void Main(string[] args)
        {
            int liczba1, liczba2;

            try
            {
                Console.WriteLine("Podaj dwie liczby:");
                liczba1 = int.Parse(Console.ReadLine());
                liczba2 = int.Parse(Console.ReadLine());
                int wynik;
                wynik = liczba1 / liczba2;
                Console.WriteLine("Wynik operacji: " + wynik);
            }
            catch (ArithmeticException ex)
            {

            }
            catch (FormatException ex)
            {

            }
            catch (SystemException ex)
            {

            }
            catch (Exception ex)
            {

            }




            //wynik = Ilotraz(liczba1, liczba2);
            //wynik = Metoda();
            //liczba1 = Int32.MaxValue;
            //liczba1++;

            Console.ReadLine();
        }
    }
}
