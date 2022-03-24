using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czwarty_projekt
{
    class Prostokat : Czworokat
    {
        public Prostokat(string nazwa, int a, int b) : base(nazwa, a, b, a, b)
        {
            
        }

        public override void OpliczPole()
        {
            pole = bokA * bokB;
        }
    }
}
