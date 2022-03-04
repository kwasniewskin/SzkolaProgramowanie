using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czwarty_projekt
{
    abstract class Czworokat
    {
        protected int bokA, bokB, bokC, bokD;
        protected int pole, obwod;
        protected string nazwa;

        public Czworokat(string nazwa, int a, int b, int c, int d)
        {
            this.nazwa = nazwa;
            bokA = a;
            bokB = b;
            bokC = c;
            bokD = d;
        }

        public abstract void OpliczPole();

        public virtual void ObliczObwod()
        {
            obwod = bokA + bokB + bokC + bokD;
        }

        public void WyswietlDane()
        {
            Console.WriteLine();
            Console.WriteLine("Obiekt o nazwie " + nazwa);
            Console.WriteLine("Bok a = " + bokA);
            Console.WriteLine("Bok b = " + bokB);
            Console.WriteLine("Bok c = " + bokC);
            Console.WriteLine("Bok d = " + bokD);
            Console.WriteLine($"Obwod = {obwod}");
            Console.WriteLine($"Pole = {pole}");
        }
    }
}
