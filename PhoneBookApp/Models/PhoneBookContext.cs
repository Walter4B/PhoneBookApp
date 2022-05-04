using Microsoft.EntityFrameworkCore;

namespace PhoneBookApp.Models
{
    internal class PhoneBookContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\LocalDBDemo;Database=PhoneBookDB;Trusted_Connection=True;");
        }
    }
}
