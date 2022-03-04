using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statyczność
{
    class Osoba 
    {
        public static string imie;
        public string nazwisko;
        public byte wiek;

        public static int ileOsob = 0;

        public Osoba(string i, string nazwisko, byte wiek)
        {
            imie = i;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            ileOsob++;
        }

        public static int IleOsobUtworzono()
        {
            return ileOsob;
        }

        public override string ToString()
        {
            return "Imie: " + imie + " nazwisko: " + nazwisko + " wiek: " + wiek;
        }
    }
}
