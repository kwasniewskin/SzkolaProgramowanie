using Microsoft.EntityFrameworkCore;
using Quiz.Baza_danych.Model;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Baza_danych.Context
{
    //database first
    //Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models


    //Scaffold-DbContext -provider Microsoft.EntityFrameworkCore.SqlServer -connection "Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;"  -OutputDir Models -ContextDir Context -DataAnnotations

    //add-migration PierwszaMigracjaQuizDB
    //update-database
    //https://zdalnyadmin.com.pl/mef-dla-poczatkujacych/

    //Sql server
    //https://www.modestprogrammer.pl/wprowadzenie-do-entity-framework-core-wspolpraca-z-baza-danych-w-csharpie


    //MySql
    //https://www.c-sharpcorner.com/article/tutorial-use-entity-framework-core-5-0-in-net-core-3-1-with-mysql-database-by2/


    //https://plawgo.pl/2021/06/01/entity-framework-core-dbfunction/

    //dociąganie danych
    //https://docs.microsoft.com/pl-pl/ef/core/querying/related-data/


    //DATABASE FIRST
    //https://docs.microsoft.com/pl-pl/ef/core/managing-schemas/scaffolding?tabs=vs
    //Scaffold-DbContext 'Filename=Northwind.db' Microsoft.EntityFrameworkCore.Sqlite -Namespace DFWebApplication.Entities -DataAnnotations -ContextDir Northwind -OutputDir Models
    public class SqlDbContext : DbContext
    {
        //public SqlDbContext(DbContextOptions opt):base(opt)
        public SqlDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            IConfigurationRoot config = builder.Build();
            string connectionString = config.GetConnectionString("default");
            //var connectionString = config.GetSection("ConnectionStrings")["default"];
            //optionsBuilder.EnableSensitiveDataLogging().UseSqlServer(connectionString);
            optionsBuilder.UseSqlite("Filename=TestDatabase.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Pytanie> Pytania { get; set; }
        public DbSet<Odpowiedz> Odpowiedzi { get; set; }
    }
}
