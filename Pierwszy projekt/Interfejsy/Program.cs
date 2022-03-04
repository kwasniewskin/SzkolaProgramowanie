using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Usb usb = new Usb("Obiekt Usb");
            int dana = usb.PobierzDana();
            usb.WyslijDana(dana);

            Hdmi hdmi = new Hdmi("Obiekt Hdmi");
            dana = hdmi.PobierzDana();
            hdmi.WyslijDana(dana);

            ProcujNaPorcie(usb);
            ProcujNaPorcie(hdmi);

            Console.ReadLine();
        }

        static void ProcujNaPorcie(Port p)
        {
            p.Informacja();
            p.WyslijDana(2);
        }

        static void ProcujNaPorcie2(IPort p)
        {
           // p.Informacja();
            p.WyslijDana(2);
            p.PobierzDana();
        }

        static void ProcujNaPorcie3(IPort p)
        {
            //p.Informacja();
            p.WyslijDana(2);
            p.PobierzDana();
        }
    }
}
