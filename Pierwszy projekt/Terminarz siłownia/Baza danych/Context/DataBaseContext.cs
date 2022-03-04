using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Terminarz_siłownia.Baza_danych.Model;

namespace Terminarz_siłownia.Baza_danych.Context
{
    class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=bazaTrening.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Osoba> Osoby { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Cwiczenie> Cwiczenia { get; set; }
    }
}
