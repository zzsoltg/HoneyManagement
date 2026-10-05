using Common.Model;
using Microsoft.EntityFrameworkCore;

namespace Common.Database;

public class ApiaryContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\zimme\\source\\repos\\zzsoltg\\HoneyManagement\\Common\\Db\\apiary.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Image)
            .HasConversion(new ImageConverter());
    }
}
