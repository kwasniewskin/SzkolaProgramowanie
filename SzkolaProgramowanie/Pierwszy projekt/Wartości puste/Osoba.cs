using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wartości_puste
{
    class Osoba 
    {
        public static string imie;
        public string nazwisko;
        public byte? wiek;
        public Osoba(string i, string nazwisko, byte? wiek)
        {
            imie = i;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }

        public override string ToString()
        {
            return "Imie: " + imie + " nazwisko: " + nazwisko + " wiek: " + wiek;
        }
    }
}
