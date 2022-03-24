using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_danych___wzorzec.Tools
{
    static class Tools
    {
        private static IConfigurationBuilder builder;
        private static IConfigurationRoot config;

        static Tools()
        {
            builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            config = builder.Build();
        }

        public static string GetConnectionString()
        {
            string connectionString = "";

            string nameOfConnectionString = config.GetSection("NameOfConnectionString").Value;

            //connectionString = config.GetSection("ConnectionStrings")[nameOfConnectionString];
            connectionString = config.GetConnectionString(nameOfConnectionString);

            return connectionString;
        }

        public static string GetNameOfProvider()
        {
            string nameOfProvider = config.GetSection("NameOfProvider").Value;

            return nameOfProvider;
        }
    }
}
