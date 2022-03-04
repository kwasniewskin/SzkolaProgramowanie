using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwszy_projekt
{
    class Osoba : IComparable<Osoba>
    {
        //public:
        public string imie;
        public string nazwisko;
        public byte wiek;

        public int CompareTo(Osoba other)
        {
            return wiek > other.wiek ? 1 : (wiek == other.wiek ? 0 : -1);
        }
        //private:
        //protected:
    }
}
