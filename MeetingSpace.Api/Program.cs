using MeetingSpace.Api.Models;
using MeetingSpace.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
  options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

var rooms = new List<MeetingRooms>();

app.MapGet("/api/rooms", () =>
  Results.Ok(rooms));

app.Run();