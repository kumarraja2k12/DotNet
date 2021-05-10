using Microsoft.EntityFrameworkCore;
using Vidly.Models.Customers;
using Vidly.Models.Movies;

public class VidlyDbContext : DbContext
{
    public VidlyDbContext (DbContextOptions<VidlyDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Movie> Movies { get; set; }

    public DbSet<MembershipType> MembershipType { get; set; }

    public DbSet<Genre> Genre { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Customer>().ToTable("Customer");
        //modelBuilder.Entity<Movie>().ToTable("Movies");
    }
}
