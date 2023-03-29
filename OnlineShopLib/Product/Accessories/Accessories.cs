using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib.Accessories
{
    public class accessories : Product
        {
            public string TypeOfAccessory { get; set; }
            public Accessories(int price, string typeOfAccessory) : base(price)
            {
            TypeOfAccessory = typeOfAccessory;
            }

            public override void About()
            {
                Console.WriteLine($"Accessory has {Price} price and {TypeOfAccessory} type ");
            }
        }
    
}
