using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_danych.Dto
{
    public class OdpowiedzUpdateDto
    {
        public int Id { get; set; }
        public string TrescOdpowiedzi { get; set; }
        public bool CzyPoprawna { get; set; }
        public int PytanieId { get; set; }
    }
}
