using Microsoft.EntityFrameworkCore;
using Vidly.Models.Customers;

public class VidlyDbContext : DbContext
{
    public VidlyDbContext (DbContextOptions<VidlyDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().ToTable("Customer");
    }
}
