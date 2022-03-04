using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKlienta
{
    class NowyKlient
    {
        private ClientConnection.ClientConnection clientConnection;
        public NowyKlient(ClientConnection.ClientConnection clientConnection)
        {
            this.clientConnection = clientConnection;
        }

        public void Wykonaj()
        {
            Console.Clear();
            string imie, nazwisko, haslo;
            Console.WriteLine("Podaj imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj haslo:");
            haslo = Console.ReadLine();
            Klient klient = clientConnection.DodajKlienta(imie, nazwisko, haslo);

            if (klient != null)
            {
                Console.WriteLine("Utworzono konto klienta o numerze " + klient.IdKlienta);
            }
            else
                Console.WriteLine("Nie usało się utworzyć konta klienta.");
            Console.ReadLine();
        }

    }
}
