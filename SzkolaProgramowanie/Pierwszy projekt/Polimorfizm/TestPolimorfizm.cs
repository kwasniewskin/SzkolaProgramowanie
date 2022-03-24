using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm
{
    class Baza
    {
        protected int x;
        public void HelloWorld()
        {
            Console.WriteLine("Hello world");
            x = (int)1.5;
        }

        public virtual void Wyswietl()
        {
            Console.WriteLine("Metoda wyswietl z klasy Baza");
        }
    }

    class A : Baza
    {
        public override void Wyswietl()
        {
            Console.WriteLine("Metoda wyswietl z klasy A");
            x = 1;
        }
    }

    class B : Baza
    {
        public override void Wyswietl()
        {
            Console.WriteLine("Metoda wyswietl z klasy B");
        }
    }


    class TestPolimorfizm
    {

        public void Test1()
        {
            A a = new A();
            /*Console.WriteLine(a is A);
            Console.WriteLine(a is B);
            Console.WriteLine(a is Baza);
            Console.WriteLine(a is Object);*/
            a.Wyswietl();
            //a.x = 1;
            //a.HelloWorld();

            B b = new B();
            b.Wyswietl();
            //b.HelloWorld();

            Baza baza = b;
            //baza.HelloWorld();
            baza.Wyswietl();
        }

        public void Test2()
        {
            A a = new A();
            B b = new B();

            Metoda1(a);
            Metoda2(b);

            Metoda(a);
            Metoda(b);


        }

        private void Metoda(Baza baza)
        {
            baza.Wyswietl();
        }

        private void Metoda1(A a)
        {
            a.Wyswietl();
        }

        private void Metoda2(B b)
        {
            b.Wyswietl();
        }

    }

    
}
