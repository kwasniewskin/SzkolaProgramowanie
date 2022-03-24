using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_danych.Dto
{
    public class OdpowiedzReadDto
    {
        public int Id { get; set; }
        public string TrescOdpowiedzi { get; set; }
        public bool CzyPoprawna { get; set; }
        public int PytanieId { get; set; }
    }
}
