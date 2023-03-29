using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib
{
    public class Product
    {
        public Product(int price)
        {
            Price = price;
        }
        public int Price { get; set; }
        public virtual void About()
        {
            Console.WriteLine($"Product has {Price} price");
        }
    }
}
