using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class TrojkatRownoramienny: Trojkat
    {
        public TrojkatRownoramienny(string nazwa, double bokA,
                                    double bokB, double wysokoscA) 
            : base(nazwa, bokA, bokB, bokB, wysokoscA)
        {

        }
    }
}
