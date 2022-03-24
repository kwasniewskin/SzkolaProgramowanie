using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty.Zdarzenia
{
    class Liczba
    {
        private int numer;

        public event Action<int> delegataZmianaPolaNumer;
        public Action<int,int> delegataZmianaPolaNumerStaryNowy;

        public int Numer
        {
            get
            {
                return numer;
            }
            set
            {
                if (delegataZmianaPolaNumerStaryNowy != null)
                    delegataZmianaPolaNumerStaryNowy(numer, value);
                numer = value;
                if (delegataZmianaPolaNumer!=null)
                {
                    delegataZmianaPolaNumer?.Invoke(value);
                    delegataZmianaPolaNumer(value);
                }
            }
        }

        public void Zeruj()
        {
            Numer = 0;
        }

    }
}
