using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.Database;
internal class Instance : DbContext
{
    public DbSet<Models.Contact> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAPTOP-LFCOM607;Database=PhoneBook;Integrated Security=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.Contact>().HasKey(c => c.Id);

    }
}