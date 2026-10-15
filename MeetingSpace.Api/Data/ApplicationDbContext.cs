using MeetingSpace.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace MeetingSpace.Api.Data;
using Booknings.Model;
public class ApplicationDbContext : DbContext{

  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
{
}

public DbSet<MeetingRooms> MeetingRooms { get; set; }
public DbSet<Bookning> Booknings { get; set; }
}
