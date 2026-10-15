using MeetingSpace.Api.Models;
using MeetingSpace.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
  options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();



app.MapGet("/api/rooms", async (ApplicationDbContext db) =>
{
  var rooms = await db.MeetingRooms.ToListAsync();

  return Results.Ok(rooms);
});

app.Run();