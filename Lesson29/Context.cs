using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson29.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson29
{
    public class Context: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Order>()
                .HasOne(order => order.Customer)
                .WithMany(customer => customer.Orders)
                .HasForeignKey(order => order.CustomerId);

            builder.Entity<Order>()
               .HasOne(order => order.Employee)
               .WithMany(employee => employee.Orders)
               .HasForeignKey(order => order.EmployeeId);
 
            builder.Entity<Order>()
                .HasMany(order => order.Products)
                .WithMany(product => product.Orders)
                .UsingEntity<OrderProduct>(
                    typeBuilder => typeBuilder
                        .HasOne(orderProduct => orderProduct.Product).WithMany()
                        .HasForeignKey(orderProduct => orderProduct.ProductId),
                    typeBuilder => typeBuilder
                        .HasOne(orderProduct => orderProduct.Order).WithMany()
                        .HasForeignKey(orderProduct => orderProduct.OrderId),
                    typeBuilder => typeBuilder
                        .HasKey(orderProduct =>
                            new { orderProduct.ProductId, orderProduct.OrderId }));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lesson29;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "Trust Server Certificate=False;Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False");
        }
    }
}
