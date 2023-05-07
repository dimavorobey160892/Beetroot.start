using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29.Models
{
    public record Order : MyEntity
    {
        public Order() { }
        public Order(int id, int customerId, int employerId, string info)
        {
            Id = id;
            CustomerId = customerId;
            EmployeeId = employerId;
            Info = info;
        }

        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string Info { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
