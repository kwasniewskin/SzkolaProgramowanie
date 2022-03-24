using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    abstract class Figura
    {
        protected string nazwa;
        protected double pole;
        protected double obwod;

        protected Dictionary<string, object> kolekcjaPolDospakowania = new Dictionary<string, object>();

        public Figura(string nazwa)
        {
            this.nazwa = nazwa;
            pole = 0;
            obwod = 0;
        }

        public Figura(Dictionary<string, object> dana)
        {
            if (dana.ContainsKey("nazwa"))
                nazwa = dana["nazwa"].ToString();
            else
                nazwa = "";

            /*if (dana.ContainsKey("pole"))
                pole = (double) dana["pole"];
            else
                pole = 0;

            if (dana.ContainsKey("obwod"))
                obwod = (double)dana["obwod"];
            else
                obwod = 0;*/

            //pole = 0;
            //obwod = 0;
        }

        public abstract void ObliczPole();

        public abstract void ObliczObwod();

        public virtual void Info()
        {
            Console.WriteLine("Informacja o obiekcie " + nazwa);
            Console.WriteLine("Pole " + pole);
            Console.WriteLine("Obwod " + obwod);
        }

        public virtual Dictionary<string, object> Pakuj()
        {
            Dictionary<string, object> dana = new Dictionary<string, object>();
            dana.Add("nazwa", nazwa);
            /*dana.Add("pole", pole);
            dana.Add("obwod", obwod);*/

            return dana;
        }
    }    
}
