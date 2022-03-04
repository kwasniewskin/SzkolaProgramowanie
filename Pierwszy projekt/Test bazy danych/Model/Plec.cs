using System;
using System.Collections.Generic;
using System.Text;

namespace Test_bazy_danych.Model
{
    public class Plec
    {
        public int Id { get; set; }
        public char Skrot { get; set; }
        public string Nazwa { get; set; }
        public List<Osoba> osoby { get; set; }
    }
}
