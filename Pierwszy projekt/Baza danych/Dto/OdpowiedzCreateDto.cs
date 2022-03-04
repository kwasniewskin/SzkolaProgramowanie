using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_danych.Dto
{
    public class OdpowiedzCreateDto
    {
        public string TrescOdpowiedzi { get; set; }
        public bool CzyPoprawna { get; set; }
        public int PytanieId { get; set; }
    }
}
