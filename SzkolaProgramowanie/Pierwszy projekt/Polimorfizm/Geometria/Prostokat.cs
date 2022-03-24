using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class Prostokat : Czworokat, IPakowalne
    {
        public Prostokat(string nazwa, double bokA, double bokB)
            : base(nazwa, bokA, bokB, bokA, bokB, bokB, bokB)
        {

        }

        public override void ObliczPole()
        {
            pole = bokA * bokB;
        }

        public virtual Dictionary<string, object> PakujInterfejs()
        {
            throw new NotImplementedException();
        }
    }
}
