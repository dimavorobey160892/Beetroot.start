using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29.Models
{
    public record Employee : MyEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string firstName, string lastName, DateTime birthDay,
            string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Address = address;
        }
    }
}
