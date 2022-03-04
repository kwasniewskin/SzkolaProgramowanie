using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ułamki
{
    class Ulamek
    {
        private int licznik;
        private int mianownik;

        public Ulamek(int l, int m)
        {
            licznik = l;
            mianownik = m;
            SkrocUlamek();
        }

        #region Operacje arytmetyczne

        public void Dodawanie(Ulamek u)
        {
            licznik = licznik * u.mianownik + u.licznik * mianownik;
            mianownik = mianownik * u.mianownik;
            SkrocUlamek();
        }

        public Ulamek Dodawanie2(Ulamek u)
        {
            Ulamek wynik = new Ulamek(licznik * u.mianownik + u.licznik * mianownik, mianownik * u.mianownik);
            return wynik;
            //return new Ulamek(licznik * u.licznik, mianownik * u.mianownik);
        }

        public void Odejmowanie(Ulamek u)
        {
            licznik = licznik * u.mianownik - u.licznik * mianownik;
            mianownik = mianownik * u.mianownik;
            SkrocUlamek();
        }

        public Ulamek Odejmowanie2(Ulamek u)
        {
            Ulamek wynik = new Ulamek(licznik * u.mianownik - u.licznik * mianownik, mianownik * u.mianownik);
            return wynik;
            //return new Ulamek(licznik * u.licznik, mianownik * u.mianownik);
        }

        public void Mnozenie(Ulamek u)
        {
            licznik = licznik * u.licznik;
            mianownik = mianownik * u.mianownik;
            SkrocUlamek();
        }

        public Ulamek Mnozenie2(Ulamek u)
        {
            Ulamek wynik = new Ulamek(licznik * u.licznik, mianownik * u.mianownik);
            return wynik;
            //return new Ulamek(licznik * u.licznik, mianownik * u.mianownik);
        }

        public void Dzielenie(Ulamek u)
        {
            licznik = licznik * u.mianownik;
            mianownik = mianownik * u.licznik;
            SkrocUlamek();
        }

        public Ulamek Dzielenie2(Ulamek u)
        {
            Ulamek wynik = new Ulamek(licznik * u.mianownik, mianownik * u.licznik);
            return wynik;
            //return new Ulamek(licznik * u.licznik, mianownik * u.mianownik);
        }

        #endregion

        #region Operacje arytmetyczne - operatory

        public static Ulamek operator +(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.mianownik + u2.licznik * u1.mianownik, u1.mianownik * u2.mianownik);
        }

        public static Ulamek operator -(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.mianownik - u2.licznik * u1.mianownik, u1.mianownik * u2.mianownik);
        }

        public static Ulamek operator *(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.licznik, u1.mianownik * u2.mianownik);
        }

        /*public static Ulamek operator *(int liczba, Ulamek u2)
        {
            return new Ulamek(liczba * u2.licznik, 1 * u2.mianownik);
        }*/

        public static Ulamek operator /(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.mianownik, u1.mianownik * u2.licznik);
        }

        #endregion

        #region Operacje porównania

        public bool Wieksza(Ulamek u)
        {
            if (licznik * u.mianownik > u.licznik * mianownik)
                return true;
            return false;
        }

        #endregion

        #region Konwersja

        public static implicit operator Ulamek(int liczba)
        {
            return new Ulamek(liczba, 1);
        }

        public static implicit operator double(Ulamek u)
        {
            return u.licznik/(double)u.mianownik;
        }

        #endregion

        #region Operacje porównania - operatory

        public static bool operator >(Ulamek u1, Ulamek u2)
        {
            return u1.Wieksza(u2);
        }

        public static bool operator <(Ulamek u1, Ulamek u2)
        {
            /*if (u1.licznik * u2.mianownik < u2.licznik * u1.mianownik)
                return true;
            return false;*/

            return u2 > u1;
            //return u2.Wieksza(u1);
        }
        #endregion

        public override string ToString()
        {
            return licznik + "/" + mianownik;
        }

        public void SkrocUlamek()
        {
            int a = licznik;
            int b = mianownik;

            while (b != 0)
            {
                int tmp = a;
                a = b;
                b = tmp % b;
            }

            if (a != 0 && a != 1 && a != -1)
            {
                licznik = licznik / a;
                mianownik = mianownik / a;
            }

            if (mianownik < 0)
            {
                licznik = licznik * (-1);
                mianownik = mianownik * (-1);
            }
        }

    }
}
