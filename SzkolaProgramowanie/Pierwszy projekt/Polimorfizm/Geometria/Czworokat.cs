using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class Czworokat : Trojkat
    {
        protected double bokD;
        protected double wysokoscA2;

        public Czworokat(string nazwa, double bokA,
                         double bokB, double bokC,
                         double bokD,
                         double wysokoscA, double wysokoscA2) 
            :base(nazwa, bokA, bokB, bokC, wysokoscA)
        {
            this.bokD = bokD;
            this.wysokoscA2 = wysokoscA2;
        }

        public override void ObliczObwod()
        {
            obwod = bokA + bokB + bokC + bokD;

            /*base.ObliczObwod();
            obwod += bokD;*/
        }

        public override void ObliczPole()
        {
            throw new NotImplementedException("Nie jesteśmy w stanie obliczyć");
        }

        public override void Info()
        {
            //base.Info();
            Console.WriteLine("Informacja o obiekcie " + nazwa);
            Console.WriteLine("Pole " + pole);
            Console.WriteLine("Obwod " + obwod);
            Console.WriteLine("Bok a " + bokA);
            Console.WriteLine("Bok b " + bokB);
            Console.WriteLine("Bok c " + bokC);
            Console.WriteLine("Bok d " + bokC);
            Console.WriteLine("Wysokosc na bok A " + wysokoscA);
            Console.WriteLine("Wysokosc na bok A2 " + wysokoscA2);
        }

    }
}
