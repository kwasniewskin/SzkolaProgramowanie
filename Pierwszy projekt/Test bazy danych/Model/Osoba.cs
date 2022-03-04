using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Test_bazy_danych.Model
{
    public class Osoba
    {
        
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Imie { get; set; }

        [Required]
        [MaxLength(45)]
        [MinLength(20)]
        public string Nazwisko { get; set; }

        public int PlecId { get; set; }
        public Plec Plec { get; set; }
    }
}
