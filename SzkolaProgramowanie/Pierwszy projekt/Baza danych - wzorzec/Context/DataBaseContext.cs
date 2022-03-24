using Baza_danych___wzorzec.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_danych___wzorzec.Context
{
    class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string nameOfProvider = Tools.Tools.GetNameOfProvider();
            string connectionString = Tools.Tools.GetConnectionString();
            switch(nameOfProvider)
            {
                case "SqlServer":
                    optionsBuilder.UseSqlServer(connectionString);
                    break;
                case "SQLLite":
                    optionsBuilder.UseSqlite(connectionString);
                    break;
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Person> Presons { get; set; }
        public DbSet<Adress> Adresses { get; set; }
    }
}
