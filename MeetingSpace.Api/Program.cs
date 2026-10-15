using Microsoft.EntityFrameworkCore;
using MeetingSpace.Api.Models;
using MeetingSpace.Api.Data;
using BookningServices;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;

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
app.MapGet("/api/bookings", async (BookningsService service) =>
{
  try{
  var Booknings = await service.GetBooknings();
  return Results.Ok(Booknings);
}catch(Exception ex)
  {
    return Results.BadRequest(ex.Message);
  }
});
app.Run();