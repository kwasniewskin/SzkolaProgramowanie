using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaUczniowie.BazaDanych.Model
{
    class Uczen
    {
        public int Id { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public int KlasaId { get; set; }
        public Klasa Klasa { get; set; }

        public int Rok_urodzenia { get; set; }
    }
}
