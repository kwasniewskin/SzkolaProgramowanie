using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    class Hdmi : Port
    {
        public Hdmi(string nazwa) : base(nazwa)
        {
            
        }

        public override void WyslijDana(int dana)
        {
            dana = dana * 3;
            Console.Write($"Dana {dana} została wysłana poprzez ");
            Console.WriteLine($"obiekt o nazwie {nazwa}");
        }

        public override int PobierzDana()
        {
            Console.WriteLine("Podaj dana dla obiektu " + nazwa);
            string danaKonsoli = Console.ReadLine();

            int dana;
            dana = int.Parse(danaKonsoli);
            dana = dana * 3;
            Console.WriteLine($"Dana {dana} została pobrana z obiektu o nazwie " + nazwa);
            return dana;
        }

    }
}
