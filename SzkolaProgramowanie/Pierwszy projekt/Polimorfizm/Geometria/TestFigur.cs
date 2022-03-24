using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class TestFigur
    {

        public void Test1()
        {
            Trojkat trojkat = new Trojkat("Trojkat", 3, 4, 5, 2.5);
            /*trojkat.ObliczObwod();
            trojkat.ObliczPole();
            trojkat.Info();*/
            PracaNaObiekcie(trojkat);

            TrojkatRownoboczny trojkatRownoboczny = new TrojkatRownoboczny("Tr", 4, 2.5);
            /*trojkatRownoboczny.ObliczObwod();
            trojkatRownoboczny.ObliczPole();
            trojkatRownoboczny.Info();*/
            PracaNaObiekcie(trojkatRownoboczny);

            Kwadrat kwadrat = new Kwadrat("Kwadrat", 5);
            /*kwadrat.ObliczObwod();
            kwadrat.ObliczPole();
            kwadrat.Info();*/
            PracaNaObiekcie(kwadrat);

            Prostokat figura = new Kwadrat("Kwadrat", 5);
            /*figura.ObliczObwod();
            figura.ObliczPole();
            figura.Info();*/
            PracaNaObiekcie(figura);

            Trojkat trojkat1 = new Kwadrat("Kwadrat", 5);
            /*trojkat1.ObliczObwod();
            trojkat1.ObliczPole();
            trojkat1.Info();*/
            PracaNaObiekcie(trojkat1);

            Kolo kolo = new Kolo("Koło", 6);
            /*kolo.ObliczObwod();
            kolo.ObliczPole();
            kolo.Info();*/
            PracaNaObiekcie(kolo);

            //Figura f = new Figura("adsads");

            SpakujIWyslij(kolo);

            Pies pies = new Pies();
            SpakujIWyslij(pies);

            /*List<int> l = new System.Collections.Generic.List<int>();
            l.Sort(new Obiekt())*/
        }

        void PracaNaObiekcie(Figura f)
        {
            f.ObliczObwod();
            f.ObliczPole();
            f.Info();
        }

        public void SpakujIWyslij(Figura obiektDoWyslania)
        {
            Dictionary<string, object> dana = obiektDoWyslania.Pakuj();
        
            WyslijDane wyslijDane = new WyslijDane();
            wyslijDane.Wyslij(dana);
        }

        public void SpakujIWyslij(Zwierze obiektDoWyslania)
        {
            Dictionary<string, object> dana = obiektDoWyslania.Pakuj();

            WyslijDane wyslijDane = new WyslijDane();
            wyslijDane.Wyslij(dana);
        }

        public void SpakujIWyslij(Object obiektDoWyslania)
        {
            Dictionary<string, object> dana = null;

            Zwierze z = obiektDoWyslania as Zwierze;
            if (z != null)
                dana = z.Pakuj();
            Figura f = obiektDoWyslania as Figura;
            if (f != null)
                dana = f.Pakuj();

            WyslijDane wyslijDane = new WyslijDane();
            wyslijDane.Wyslij(dana);
        }

        public void SpakujIWyslij(IPakowalne obiektDoWyslania)
        {
            Dictionary<string, object> dana = obiektDoWyslania.PakujInterfejs();
           
            WyslijDane wyslijDane = new WyslijDane();
            wyslijDane.Wyslij(dana);
        }
    }

    class Zwierze
    {
        //.....
        public virtual Dictionary<string, object> Pakuj()
        {
            return null;
        }
    }

    class Pies: Zwierze
    {
        //.....
        public override Dictionary<string, object> Pakuj()
        {
            return null;
        }
    }

    class Kot: Zwierze, IPakowalne
    {
        //.....
        public override Dictionary<string, object> Pakuj()
        {
            return null;
        }

        public Dictionary<string, object> PakujInterfejs()
        {
            throw new NotImplementedException();
        }
    }

    class WyslijDane
    {
        public void Wyslij(Dictionary<string, object> dane)
        {
            //kod do wysyłania
        }
    }
}
