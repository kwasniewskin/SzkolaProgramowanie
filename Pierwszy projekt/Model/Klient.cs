using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Klient
    {
        private string imie;
        private string nazwisko;
        private int idKlienta;
        private string haslo;

        public int IdKlienta
        {
            get
            {
                return idKlienta;
            }
        }

        public string Haslo
        {
            get { return haslo; }
        }

        public Klient(string imie, string nazwisko, int idKlienta, string haslo)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.idKlienta = idKlienta;
            this.haslo = haslo;
        }
    }
}
