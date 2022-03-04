using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Test
{
    class A
    {
        //...
        public void XYZ()
        {

        }

        public virtual void Info()
        {
            Console.WriteLine("Metoda info z klasy A");
        }
    }

    class B : A
    {
        //...
        public void XYZ2()
        {

        }
    }

    class C : A
    {
        //...
    }

    class D : B
    {
        //...
    }

    class E: B
    {
        public new void XYZ2()
        {
            XYZ();
            base.XYZ();
        }

        public new void XYZ()
        {
            //...
            base.XYZ();
        }

        public void XYZ(int x)
        {

        }

        public override void Info()
        {
            Console.WriteLine("Metoda info z klasy E");
        }

    }

    class F : B
    {
        public void XYZ(int x, float b)
        {

        }

    }



    class Testowa
    {
        public void test()
        {
            B b = new B();
            b.XYZ();

            E e = new E();
            e.XYZ();

            F f = new F();
            f.XYZ();

            E ee = new E();
            ee.XYZ(); // z klasy E
            B bb = new E();
            bb.XYZ(); // z klasy A
            A aa = new E();
            aa.XYZ(); //z klasy A
            //C cc = new F();


            E eee = new E();
            eee.Info(); // z klasy E
            B bbb = new D();
            bbb.Info(); // z klasy A
            A aaa = new E();
            aaa.Info(); //z klasy A

            A aaaa;
            if ((new Random()).Next() % 2 == 0)
                aaaa = new C();
            else
                aaaa = new F();
            aaaa.Info();
        }

    }


}
