using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib
{
    public class SmartPhone : Product
    {
        public string OS { get; set; }
        public SmartPhone(int id, string name, int price, int count, string os) : base(id, name, price, count)
        {
            OS = os;
        }

        public override void About()
        {
            Console.WriteLine($"Smartphone has {Price} price and {OS} operation system ");
        }
    }
}
