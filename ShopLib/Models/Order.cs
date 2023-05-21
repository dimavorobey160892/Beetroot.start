using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib.Models
{
    public record Order: BaseEntity
    {
        public Order() { }
        public Order(int id, int userId, string info)
        {
            Id = id;
            UserId = userId;
            Info = info;
        }

        public int UserId { get; set; }
        public string Info { get; set; }
        public virtual User User { get; set; }

    }
}
