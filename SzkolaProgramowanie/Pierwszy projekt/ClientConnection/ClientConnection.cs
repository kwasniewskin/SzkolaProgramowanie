using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConnection
{
    public class ClientConnection
    {
        private ServerConnection.ServerConnection serverConnection;

        public ClientConnection()
        {
            serverConnection = new ServerConnection.ServerConnection();
        }

        public Klient DodajKlienta(string imie, string nazwisko, string haslo)
        {
            return serverConnection.DodajKlienta(imie, nazwisko, haslo);
        }

        public Klient ZalogujDoKonta(int idKlienta, string haslo)
        {
            return serverConnection.ZalogujDoKonta(idKlienta, haslo);
        }

        public List<Konto> ListaKontKlienta(Klient klient)
        {
            return serverConnection.ListaKontKlienta(klient);
        }

        public Konto DodajKonto(Klient klient)
        {
            return serverConnection.DodajKonto(klient);
        }

        public Konto ZwrocKonto(Klient klient, int numerKonta)
        {
            return serverConnection.ZwrocKonto(klient, numerKonta);
        }

        public bool Wplata(Konto konto, float kwota)
        {
            return serverConnection.Wplata(konto, kwota);
        }

        public bool Przelew(Konto kontoZrodlowe, int numerKontaDocelowego, float kwota)
        {
            return serverConnection.Przelew(kontoZrodlowe, numerKontaDocelowego, kwota);
        }

    }
}
