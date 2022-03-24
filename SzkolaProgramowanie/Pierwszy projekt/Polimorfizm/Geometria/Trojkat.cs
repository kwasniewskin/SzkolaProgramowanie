using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class Trojkat : Figura
    {
        protected double bokA, bokB, bokC;
        protected double wysokoscA;

        public Trojkat(string nazwa, double bokA,
                       double bokB, double bokC,
                       double wysokoscA): base(nazwa)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            this.bokC = bokC;
            this.wysokoscA = wysokoscA;
        }

        public Trojkat(Dictionary<string, object> dana) : base(dana)
        {
            if (dana.ContainsKey("bokA"))
                bokA = (double)dana["bokA"];
            else
                bokA = 0;
            if (dana.ContainsKey("bokB"))
                bokB = (double)dana["bokB"];
            else
                bokB = 0;

            if (dana.ContainsKey("bokC"))
                bokC = (double)dana["bokC"];
            else
                bokC = 0;

            if (dana.ContainsKey("wysokoscA"))
                wysokoscA = (double)dana["wysokoscA"];
            else
                wysokoscA = 0;

            ObliczObwod();
            ObliczPole();

        }

        public override void ObliczPole()
        {
            pole = bokA * wysokoscA / 2;
        }

        public override void ObliczObwod()
        {
            obwod = bokA + bokB + bokC;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Bok a " + bokA);
            Console.WriteLine("Bok b " + bokB);
            Console.WriteLine("Bok c " + bokC);
            Console.WriteLine("Wysokosc na bok A " + wysokoscA);
        }

        public override Dictionary<string, object> Pakuj()
        {
            Dictionary<string, object> dana = base.Pakuj();
            dana.Add("bokA", bokA);
            dana.Add("bokB", bokB);
            dana.Add("bokC", bokC);
            dana.Add("wysokoscA", wysokoscA);

            return dana;
        }
    }
}
