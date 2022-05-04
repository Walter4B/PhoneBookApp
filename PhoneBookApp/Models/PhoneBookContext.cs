using System;
using System.Data;
using ConsoleTableExt;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


namespace PhoneBookApp.Models
{
    internal class PhoneBookContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connectionKey"].ConnectionString);
        }
    }
}
