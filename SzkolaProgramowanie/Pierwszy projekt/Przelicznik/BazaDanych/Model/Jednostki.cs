using System;
using System.Collections.Generic;
using System.Text;

namespace Przelicznik.BazaDanych.Model
{
    class Jednostki
    {
        public int Id { get; set; }

        public string Nazwa { get; set; }

        public string Symbol { get; set; }

        public int RodzajId { get; set; }
        public Rodzaj Rodzaj { get; set; }
    }
}
