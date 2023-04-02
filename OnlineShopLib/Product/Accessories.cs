using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib
{
    public class Accessories : Product
    {
        public string TypeOfAccessory { get; set; }
        public Accessories(int id, string name, int price, int count, string typeOfAccessory) : base(id, name, price, count)
        {
            TypeOfAccessory = typeOfAccessory;
        }

        public override void About()
        {
            Console.WriteLine($"Accessory has {Price} price and {TypeOfAccessory} type ");
        }
    }

}
