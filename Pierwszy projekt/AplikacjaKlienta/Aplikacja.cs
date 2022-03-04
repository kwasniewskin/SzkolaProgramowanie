using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKlienta
{
    class Aplikacja
    {
        ClientConnection.ClientConnection clientConnection;

        public void Start()
        {
            clientConnection = new ClientConnection.ClientConnection();
            do
            {
                MenuGlowne();
                int opcja = WybranaOpcja();
                switch (opcja)
                {
                    case 0:
                        return;
                    case 1:
                        new NowyKlient(clientConnection).Wykonaj();
                        break;
                    case 2:
                        ZalogujKlienta();
                        break;
                }
            } while (true);
        }

        private void MenuGlowne()
        {
            Console.Clear();
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("1. Nowy klient.");
            Console.WriteLine("2. Zaloguj klienta.");

            Console.WriteLine("0. Zamknij program");
        }

        private int WybranaOpcja()
        {
            string opcjaStr = Console.ReadLine();
            int opcja;
            if (!int.TryParse(opcjaStr, out opcja))
                return -1;
            return opcja;
        }

        private void ZalogujKlienta()
        {
            int idKlienta;
            string haslo;
            string idKlientaStr;
            Console.Clear();
            do
            {
                Console.WriteLine("Podaj numer klienta:");
                idKlientaStr = Console.ReadLine();
            } while (!int.TryParse(idKlientaStr, out idKlienta));
            Console.WriteLine("Podaj hasło:");
            haslo = Console.ReadLine();

            Klient klient = clientConnection.ZalogujDoKonta(idKlienta, haslo);

            if (klient == null)
            {
                Console.WriteLine("Brak takiego konta.");
                Console.ReadLine();
                return;
            }

            do
            {
                MenuOpcjeKlienta();
                int opcja = WybranaOpcja();
                switch (opcja)
                {
                    case 0:
                        return;
                    case 1:
                        ListaKontKlienta(klient);
                        break;
                    case 2:
                        OpcjeWybranegoKonta(klient);
                        break;
                    case 3:
                        DodajKonto(klient);
                        break;
                }
            } while (true);

        }

        private void MenuOpcjeKlienta()
        {
            Console.Clear();
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("1. Lista kont.");
            Console.WriteLine("2. Opcje wybranego konta.");
            Console.WriteLine("3. Nowe konto.");

            Console.WriteLine("0. Powrót to poprzedniego menu");
        }

        private List<Konto> ListaKontKlienta(Klient klient)
        {
            Console.Clear();
            List<Konto> listaKont = clientConnection.ListaKontKlienta(klient);
            if (listaKont != null && listaKont.Count > 0)
            {
                Console.WriteLine("Lista kont klienta:");
                foreach (Konto konto in listaKont)
                {
                    Console.WriteLine("Konto o numerze " + konto.NumerKonta);
                }
            }
            else
                Console.WriteLine("Brak kont.");

            Console.ReadLine();
            return listaKont;
        }

        private Konto DodajKonto(Klient klient)
        {
            Konto konto = clientConnection.DodajKonto(klient);
            if (konto != null)
                Console.WriteLine("Udało się założyć konto o numerze " + konto.NumerKonta);
            else
                Console.WriteLine("Nie udało się założyć konta");

            Console.ReadLine();
            return konto;
        }

        private void OpcjeWybranegoKonta(Klient klient)
        {
            int numerKonta;
            string numerKontaStr;
            Console.Clear();
            do
            {
                Console.WriteLine("Podaj numer konta:");
                numerKontaStr = Console.ReadLine();
            } while (!int.TryParse(numerKontaStr, out numerKonta));

            Konto konto = clientConnection.ZwrocKonto(klient, numerKonta);

            if (konto == null)
            {
                Console.WriteLine("Brak takiego konta powiązanego z zalogowanym użytkownikiem");
                Console.ReadLine();
                return;
            }
            do
            {
                MenuOpcjeWybranegoKonta();
                int opcja = WybranaOpcja();
                switch (opcja)
                {
                    case 0:
                        return;
                    case 1:
                        InformacjaOKoncie(konto);
                        break;
                    case 2:
                        WplataNaKonto(konto);
                        break;
                    case 3:
                        Przelew(konto);
                        break;
                }
            } while (true);
        }

        private void MenuOpcjeWybranegoKonta()
        {
            Console.Clear();
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("1. Informacja o koncie.");
            Console.WriteLine("2. Wpłata na konto.");
            Console.WriteLine("3. Przelew na inne konto.");

            Console.WriteLine("0. Powrót to poprzedniego menu");
        }

        private void InformacjaOKoncie(Konto konto)
        {
            Console.Clear();
            konto.Info();
            Console.ReadLine();
        }

        private void WplataNaKonto(Konto konto)
        {
            float kwota;
            string kwotaStr;
            Console.Clear();
            do
            {
                Console.WriteLine("Podaj kwotę:");
                kwotaStr = Console.ReadLine();
            } while (!float.TryParse(kwotaStr, out kwota));
            if (clientConnection.Wplata(konto, kwota))
            {
                konto.Wplata(kwota);
                Console.WriteLine("Wpłata zakończona sukcesem");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Wpłata zakończona niepowodzeniem");
            Console.ReadLine();
        }

        private void Przelew(Konto konto)
        {
            float kwota;
            string kwotaStr;
            Console.Clear();
            do
            {
                Console.WriteLine("Podaj kwotę:");
                kwotaStr = Console.ReadLine();
            } while (!float.TryParse(kwotaStr, out kwota));

            int numerKontaDocelowego;
            string numerKontaDocelowegoStr;
            Console.Clear();
            do
            {
                Console.WriteLine("Podaj numer konta na który należy wykonać przelew:");
                numerKontaDocelowegoStr = Console.ReadLine();
            } while (!int.TryParse(numerKontaDocelowegoStr, out numerKontaDocelowego));

            if (clientConnection.Przelew(konto, numerKontaDocelowego, kwota))
            {
                konto.Wyplata(kwota);
                Console.WriteLine("Przelew zakończony sukcesem");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Przelew zakończony niepowodzeniem");
            Console.ReadLine();
        }

    }
}
