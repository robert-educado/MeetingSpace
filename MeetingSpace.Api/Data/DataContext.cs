using Microsoft.EntityFrameworkCore;
using Booknings.Model;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Bookning> Booknings { get; set; }
}