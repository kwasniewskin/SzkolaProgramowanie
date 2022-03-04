using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Konto
    {
        private float saldo;
        private int numerKonta;
        public int NumerKonta
        {
            get
            {
                return numerKonta;
            }
        }

        public Konto(int numerKonta)
        {
            this.numerKonta = numerKonta;
            saldo = 0;
        }

        public bool Wplata(float kwota)
        {
            if (kwota > 0)
            {
                saldo += kwota;
                return true;
            }
            return false;
        }

        public bool Wyplata(float kwota)
        {
            if (kwota > 0 && saldo > kwota)
            {
                saldo -= kwota;
                return true;
            }
            return false;
        }

        public void Info()
        {
            Console.WriteLine("Numer konta " + numerKonta);
            Console.WriteLine("Saldo konta " + saldo);
        }
    }
}
