using AplikacjaUczniowie.BazaDanych.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplikacjaUczniowie.BazaDanych.Context
{
    class DataBaseContext : DbContext
    {
        //add-migration "message" -OutputDir BazaDanych/Migrations
        //update-database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=bazaUczniowie.db");
            base.OnConfiguring(optionsBuilder);
        }

            public DbSet<Uczen> Uczen { get; set; }

            public DbSet<Klasa> Klasa { get; set; }

    }
}
