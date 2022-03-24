using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czwarty_projekt
{
    class Romb : Czworokat
    {
        protected int wysokosc;

        public Romb(string nazwa, int a, int h) : base(nazwa, a, a, a, a)
        {
            wysokosc = h;
        }

        public override void OpliczPole()
        {
            pole = bokA * wysokosc;
        }
    }
}
