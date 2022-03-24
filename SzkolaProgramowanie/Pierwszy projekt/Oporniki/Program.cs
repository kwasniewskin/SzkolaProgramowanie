using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oporniki
{
    class Program
    {
        static void Main(string[] args)
        {
            Opornik opornik1 = new Opornik();
            Opornik opornik2 = new Opornik(5);

            try
            {
                opornik2.Rezystancja = -99;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Błąd " + ex.Message);
            }


            //double x = opornik1.Rezystancja;

            Console.WriteLine(opornik1);
            Console.WriteLine(opornik2);

            Opornik opornikZastepczySzeregowy = opornik1 + opornik2; // Opornik.operator+(opornik1,opornik2) // C++: opornik1.operator+(opornik2)

            Opornik opornikZastepczyRownolegly = opornik1 & opornik2;

            Console.WriteLine("Opór zastępczy szeregowy " + opornikZastepczySzeregowy);
            Console.WriteLine("Opór zastępczy równoległy " + opornikZastepczyRownolegly);

            Console.ReadLine();
        }
    }
}
