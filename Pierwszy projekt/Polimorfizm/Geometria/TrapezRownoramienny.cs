using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class TrapezRownoramienny : Trapez
    {
        public TrapezRownoramienny(string nazwa, double bokA,
                                   double bokB, double bokC,
                                   double wysokoscA) 
            : base(nazwa, bokA, bokB, bokC, bokB, wysokoscA)
        {

        }

    }
}
