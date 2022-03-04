using Bank;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerConnection
{
    public class ServerConnection
    {
        Bank.Bank bank = new Bank.Bank();

        public Klient DodajKlienta(string imie, string nazwisko, string haslo)
        {
            return bank.DodajKlienta(imie, nazwisko, haslo);
        }

        public Klient ZalogujDoKonta(int idKlienta, string haslo)
        {
            return bank.ZalogujDoKonta(idKlienta, haslo);
        }

        public List<Konto> ListaKontKlienta(Klient klient)
        {
            return bank.ZwrocListeKont(klient);
        }

        public Konto DodajKonto(Klient klient)
        {
            return bank.DodajKonto(klient);
        }

        public Konto ZwrocKonto(Klient klient, int numerKonta)
        {
            return bank.ZwrocKonto(klient, numerKonta);
        }

        public bool Wplata(Konto konto, float kwota)
        {
            return bank.Wplata(konto, kwota);
        }

        public bool Przelew(Konto kontoZrodlowe, int numerKontaDocelowego, float kwota)
        {
            return bank.Przelew(kontoZrodlowe, numerKontaDocelowego, kwota);
        }

    }
}
