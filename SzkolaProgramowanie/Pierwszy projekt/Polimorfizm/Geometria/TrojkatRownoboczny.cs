using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class TrojkatRownoboczny: TrojkatRownoramienny
    {
        public TrojkatRownoboczny(string nazwa, double bokA, double wysokoscA)
            : base(nazwa, bokA, bokA, wysokoscA)
        {

        }
    }
}
