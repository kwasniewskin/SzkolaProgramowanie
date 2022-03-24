using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ułamki
{
    class Program
    {
        static void Main(string[] args)
        {
            double u1 = 0.333333;
            double u2 = 0.75;
            double u3;

            //Ulamek ulamek1(1,3);
            //Ulamek *ulamek2 = new Ulamek(3, 4);
            Ulamek ulamek1 = new Ulamek(1, 3);
            Ulamek ulamek2 = new Ulamek(3, 4);
            Ulamek ulamek3;

            u3 = u1 * u2;

            //u3 = Ulamek.operator*(u1, u2);

            ulamek3 = ulamek1 * ulamek2;


            ulamek1.Mnozenie(ulamek2); // u1 = u1*u2;
            //ulamek1.Dodawanie(ulamek1); //u1 = u1+u2;

            //Console.WriteLine(ulamek1);
            
            ulamek3 = ulamek1.Mnozenie2(ulamek2); //u3 = u1 * u2;
            Console.WriteLine(ulamek3);

            Console.WriteLine("Obliczenie pola koła");
            Ulamek pi = new Ulamek(22, 7);
            Ulamek promien = new Ulamek(5, 1);

            Ulamek poleKola;
            poleKola = pi.Mnozenie2(promien.Mnozenie2(promien));
            poleKola = pi * promien * promien;

            Console.WriteLine(poleKola);

            Console.WriteLine("Pierwiastki równania kwadratowego:");
            Ulamek a = new Ulamek(2, 1);
            Ulamek b = new Ulamek(5, 2);
            Ulamek c = new Ulamek(-2, 3);

            //delta = b*b-4*a*c;
            Ulamek bb = b.Mnozenie2(b);
            Ulamek ac4 = a.Mnozenie2(c.Mnozenie2(new Ulamek(4, 1)));
            Ulamek delta = bb.Odejmowanie2(ac4);
            //Ulamek delta = b.Mnozenie2(b).Odejmowanie2(a.Mnozenie2(c.Mnozenie2(new Ulamek(4, 1))));
            delta = b * b - new Ulamek(4,1) * a * c;

            delta = b * b - 4 * a * c;

            Ulamek liczba = 4;
            delta = b * b - liczba * a * c;

            //if (delta > 0)
            //if (delta.Wieksza(new Ulamek(0,1)) )
            //if (delta > new Ulamek(0, 1))
            //if (Ulamek.operator>(delta,0))
            if (delta > 0)
            {
                //Ulamek x1 = 
                //Ulamek x2 = 
            }

            Ulamek test = new Ulamek(1, 3);
            int x = (int)test;

            Console.WriteLine(test);

            Console.ReadLine();
        }
    }
}
