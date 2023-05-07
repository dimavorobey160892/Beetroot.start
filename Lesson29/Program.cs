using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System;
using Microsoft.EntityFrameworkCore;
using Lesson29.Models;

namespace Lesson29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new Context();
            context.Products.Add(new Product(1, "Iphone", 1300, "apple"));
            context.SaveChanges();
        }
    }
}