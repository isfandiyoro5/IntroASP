using introAPI2.Models;
using introAPI2.Service;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var config = builder.Configuration.GetSection("Connection");
builder.Services.AddDbContext<AppDbContext>(option => option.UseNpgsql(config["connection"]));
builder.Services.AddScoped<StudentsService>();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();