using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    class Usb: Port
    {
        public Usb(string nazwa): base (nazwa)
        {

        }

        public override void WyslijDana(int dana)
        {
            Console.Write($"Dana {dana} została wysłana poprzez ");
            Console.WriteLine($"obiekt o nazwie {nazwa}");
        }

        public override int PobierzDana()
        {
            Console.WriteLine("Podaj dana dla obiektu " + nazwa);
            string danaKonsoli = Console.ReadLine();

            int dana;
            dana = int.Parse(danaKonsoli);

            Console.WriteLine($"Dana {dana} została pobrana z obiektu o nazwie " + nazwa);
            return dana;
        }
    }
}
