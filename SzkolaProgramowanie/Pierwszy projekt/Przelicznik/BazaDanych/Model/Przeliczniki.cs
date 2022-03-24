using System;
using System.Collections.Generic;
using System.Text;

namespace Przelicznik.BazaDanych.Model
{
    class Przeliczniki
    {
        public int Id { get; set; }

        public int JednostkaZrodlowaId { get; set; }
        public Jednostki JednostkaZrodlowa { get; set; }

        public int JednostkaDocelowaId { get; set; }
        public Jednostki JednostkaDocelowa { get; set; }

        public float Wartosc { get; set; }
    }
}
