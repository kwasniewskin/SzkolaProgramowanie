using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trzeci_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Pies pies = new Pies();
            pies.imie = "Azor";
            pies.DajGlos();
            pies.GonListonosza();

            Kot kot = new Kot();
            kot.imie = "Puszek";
            kot.DajGlos();
            kot.WejdzNaDrzewo();
        }
    }
}
