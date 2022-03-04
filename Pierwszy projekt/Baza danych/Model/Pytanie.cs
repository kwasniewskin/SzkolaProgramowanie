using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Baza_danych.Model
{
    public class Pytanie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        //[]
        public string TrescPytania { get; set; }

        public ICollection<Odpowiedz> Odpowiedzi { get; set; }
    }
}
