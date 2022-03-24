using Microsoft.EntityFrameworkCore;
using Przelicznik.BazaDanych.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Przelicznik.BazaDanych.Context
{
    class DataBaseContext : DbContext
    {
        //add-migration "message" -OutputDir BazaDanych/Migrations
        //update-database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=bazaPrzelicznik.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Rodzaj> Rodzaj { get; set; }

        public DbSet<Jednostki> Jednostki { get; set; }

        public DbSet<Przeliczniki> Przeliczniki { get; set; }
    }
}
