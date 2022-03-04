using System;
using System.Collections.Generic;
using System.Text;

namespace Terminarz_siłownia.Baza_danych.Model
{
    class Cwiczenie
    {
        public int Id { get; set; }
        public int IloscPowtorzen { get; set; }
        public DateTime DataCwiczenia { get; set; }
        
        public int OsobaId { get; set; }
        public Osoba Osoba { get; set; }

        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
