using Microsoft.EntityFrameworkCore;
using Lesson36.Models;
using Lesson36;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<Context>(opt=>  opt.UseInMemoryDatabase("shopDb"));
builder.Services.AddDbContext<Context>(options =>
   options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=shopDb;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "Trust Server Certificate=False;Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
