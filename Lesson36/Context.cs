using Lesson36.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Lesson36
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=shopDb;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "Trust Server Certificate=False;Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False");
        }
    }
}