using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oporniki
{
    class Opornik
    {
        protected double rezystancja;

        public double Rezystancja //(double value)
        {
            set
            {
                if (value >= 0)
                    rezystancja = value;
                else
                {
                    throw new Exception("Podano rezystancje mniejszą od zera");
                }
            }
            get
            {
                return rezystancja;
            }
        }


        public Opornik()
        {
            rezystancja = 0;
        }

        public Opornik(double r)
        {
            Rezystancja = r;
        }

        public override string ToString()
        {
            return rezystancja.ToString() + "\u03B1";
        }

        #region Metody oporników zastępczych

        public static Opornik operator +(Opornik o1, Opornik o2)
        {
            return new Opornik(o1.rezystancja + o2.rezystancja);
        }

        public static Opornik operator &(Opornik o1, Opornik o2)
        {
            if (o1.rezystancja == 0 || o2.rezystancja == 0)
                return new Opornik();
            return new Opornik(1 / o1.rezystancja + 1 / o2.rezystancja);
        }

        public static implicit operator Opornik(double wartosc)
        {
            return new Opornik(wartosc);
        }

        #endregion


    }
}
