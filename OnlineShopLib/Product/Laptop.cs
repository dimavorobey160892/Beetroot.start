using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib
{
    public class Laptop : Product
    {
        public string Type { get; set; }
        public Laptop(int id, string name, int price, int count, string type) : base(id, name, price, count)
        {
            Type = type;
        }

        public override void About()
        {
            Console.WriteLine($"Laptop has {Price} price and {Type} type ");
        }
    }
}
