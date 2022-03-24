using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty.Zdarzenia
{
    class Obserwator
    {
        public void Wyswietl(int liczba)
        {
            Console.WriteLine("Liczba z obiekcie została zmieniona na" + liczba);
        }
    }
}
