using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29.Models
{
    public record Customer : MyEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public Customer()
        {
        }

        public Customer(int id, string firstName, string lastName, int age,
            string gender, string? address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Address = address;
        }
    }

   
}
