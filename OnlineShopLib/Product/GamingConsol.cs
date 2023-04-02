using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib
{
    public class GamingConsol : Product
    {
        public string Brand { get; set; }
        public GamingConsol(int id, string name, int price, int count, string brand) : base(id, name, price, count)
        {
            Brand = brand;
        }

        public override void About()
        {
            Console.WriteLine($"Gaming console has {Price} price and {Brand} name ");
        }
    }
}
