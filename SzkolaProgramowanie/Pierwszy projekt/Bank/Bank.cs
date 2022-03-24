using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        private List<Konto> listaKont = new List<Konto>();
        private List<Klient> listaKlientow = new List<Klient>();

        private List<PowiazanieKlientKonto> powiazanieKlientKonto = new List<PowiazanieKlientKonto>();

        public Bank()
        {

        }

        public Klient ZalogujDoKonta(int idKlienta, string haslo)
        {
            return listaKlientow.FirstOrDefault(klient => klient.IdKlienta == idKlienta && klient.Haslo == haslo);
        }

        public List<Konto> ZwrocListeKont(Klient klient)
        {
            return powiazanieKlientKonto.Where(powiazanie => powiazanie.klient.IdKlienta == klient.IdKlienta).Select(powiazanie => powiazanie.konto).ToList();
        }

        public Klient DodajKlienta(string imie, string nazwisko, string haslo)
        {
            int idKlienta = listaKlientow.Count > 0 ? (listaKlientow.Max(k => k.IdKlienta) + 1) : 1;

            Klient klient = new Klient(imie, nazwisko, idKlienta, haslo);
            listaKlientow.Add(klient);
            return klient;
        }

        public Konto DodajKonto(Klient klient)
        {
            int numerKonta = listaKont.Count > 0 ? (listaKont.Max(k => k.NumerKonta) + 1) : 1;

            Konto konto = new Konto(numerKonta);
            listaKont.Add(konto);

            powiazanieKlientKonto.Add(new PowiazanieKlientKonto() { klient = klient, konto = konto });

            return konto;
        }

        public bool PowiazaneKontoKlient(int numerKonta, int idKlienta)
        {
            Klient klient = listaKlientow.FirstOrDefault(k => k.IdKlienta == idKlienta);
            if (klient == null)
                return false;
            Konto konto = listaKont.FirstOrDefault(k => k.NumerKonta == numerKonta);
            if (konto == null)
                return false;

            if (powiazanieKlientKonto.FirstOrDefault(p => p.konto.NumerKonta == numerKonta && p.klient.IdKlienta == idKlienta) != null)
                return false;

            powiazanieKlientKonto.Add(new PowiazanieKlientKonto() { klient = klient, konto = konto });

            return true;

        }

        public Konto ZwrocKonto(Klient klient, int numerKonta)
        {
            return powiazanieKlientKonto.FirstOrDefault(powiazanie=> powiazanie.klient.IdKlienta == klient.IdKlienta && powiazanie.konto.NumerKonta == numerKonta)?.konto;
        }

        public bool Wplata(Konto konto, float kwota)
        {
            Konto kontoZListy = listaKont.FirstOrDefault(kontoLista => kontoLista.NumerKonta == konto.NumerKonta);
            if (kontoZListy == null)
                return false;
            return kontoZListy.Wplata(kwota);
        }

        public bool Przelew(Konto kontoZrodlowe, int numerKontaDocelowego, float kwota)
        {
            Konto kontoDocelowe = listaKont.FirstOrDefault(konto => konto.NumerKonta == numerKontaDocelowego);
            if (kontoDocelowe == null)
                return false;
            if (kontoZrodlowe.Wyplata(kwota))
            {
                kontoDocelowe.Wplata(kwota);
                return true;
            }

            return false;
        }

    }
}
