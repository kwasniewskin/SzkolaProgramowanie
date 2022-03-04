using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_projekt
{
    class Osoba
    {
        //public:
        //public string imie;
        public string Imie
        {
            get;
            set;
        }

        private string nazwisko;
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }
        }

        private byte wiek;
        public byte Wiek //(byte value)
        {
            get
            {
                return wiek;
            }

            set
            {
                if (value < 150)
                    this.wiek = value;
                else
                    throw new Exception("Za duża wartość pola wiek");
            }
        }

        public void SetWiek(byte wiek)
        {
            if (wiek < 150)
                this.wiek = wiek;
            else
                throw new Exception("Za duża wartość pola wiek");
        }

        public byte GetWiek()
        {
            return wiek;
        }

        //private:
        //protected:
    }
}
