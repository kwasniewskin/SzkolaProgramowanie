using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Baza_danych.Model
{
    public class Odpowiedz
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string TrescOdpowiedzi { get; set; }
        [Required]
        public bool CzyPoprawna { get; set; }

        
        //[Required]
        [ForeignKey("Pytanie")]
        public int PytanieId { get; set; }
        public Pytanie Pytanie { get; set; }
    }
}
