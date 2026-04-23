using Microsoft.EntityFrameworkCore;
using MinimalAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
    .UseSnakeCaseNamingConvention());

var app = builder.Build();

app.MapGet("/", () => "Appointment API is running on AWS RDS!");

app.MapGet("/appointments", async (AppDbContext db) =>
    await db.Appointments.ToListAsync());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// app.UseHttpsRedirection();

app.Run();