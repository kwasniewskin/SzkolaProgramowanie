using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            byte wiek = 100;

            Osoba o = new Osoba();
            o.Imie = "Jan";
            //o.nazwisko = "dfsgsd";
            o.Nazwisko = "Kowalski";

            o.Wiek = wiek;
            o.SetWiek(wiek);
            
            int x = o.Wiek;
            x = o.GetWiek();


            
        }
    }
}
