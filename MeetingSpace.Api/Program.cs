using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();
builder.Services.AddDbContext<AppDbContext>(options => 
options.UseSqlServer());
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.Run();

