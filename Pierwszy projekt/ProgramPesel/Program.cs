using System;

namespace ProgramPesel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer pesel: ");
            string numerPesel = Console.ReadLine();
            try
            {
                Pesel pesel = new Pesel(numerPesel);
                //Console.WriteLine("Plec osoby numer: " + pesel.Plec);
                Console.WriteLine("Plec: " + pesel.PlecOpis);
                Console.WriteLine("Dzien urodzenia: " + pesel.DzienUrodzenia);
                //Console.WriteLine("Miesiac urodzenia osoby numer: " + pesel.MiesiacUrodzenia);
                Console.WriteLine("Miesiac urodzenia: " + pesel.MiesiacUrodzeniaOpis);
                Console.WriteLine("Rok urodzenia: " + pesel.RokUrodzenia);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
