using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29.Models
{
    public record Product : MyEntity
    {
        public Product() { }
        public Product(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
