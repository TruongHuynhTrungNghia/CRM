using Microsoft.EntityFrameworkCore;

namespace CRM.Customer.Application.Models;

public class CustomerDbContext : DbContext
{
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
    {
    }

    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=myserver;Username=customer;Password=mypass;Database=customer");

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Customer>().ToTable("Customers");
    }

    public DbSet<Customer> Customers { get; set; } = null!;
}