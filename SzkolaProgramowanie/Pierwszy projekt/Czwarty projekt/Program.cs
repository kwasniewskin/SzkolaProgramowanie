using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czwarty_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat prostokat = new Prostokat("Prostokąt", 5, 7);
            prostokat.OpliczPole();
            prostokat.ObliczObwod();
            prostokat.WyswietlDane();

            Kwadrat kwadrat = new Kwadrat("Kwadrat", 5);
            kwadrat.OpliczPole();
            kwadrat.ObliczObwod();
            kwadrat.WyswietlDane();

            Romb romb = new Romb("Romb", 5, 4);
            romb.OpliczPole();
            romb.ObliczObwod();
            romb.WyswietlDane();

            //int a =5 ;
            //float b;
            //b = a;
            //a = b;

            //Czworokat czworokat = new Czworokat("Czworokąt", 1, 2, 3, 4);

            Czworokat czworokat2 = new Prostokat("Prostokąt", 1, 2);
            czworokat2.OpliczPole();
            czworokat2.ObliczObwod();
            czworokat2.WyswietlDane();

            Prostokat prostokat2 = new Prostokat("Prostokąt", 5, 7);
            Wykonaj(prostokat2);

            Czworokat kwadrat2 = new Kwadrat("Kwadrat", 5);
            Wykonaj(kwadrat2);

            //Czworokat c1 = new Czworokat("vrew", 1, 2, 3, 4);

            Console.ReadLine();

        }

        static void Wykonaj(Czworokat c)
        {
            c.OpliczPole();
            c.ObliczObwod();
            c.WyswietlDane();
        }
    }
}
