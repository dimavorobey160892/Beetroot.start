using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        int Price { get; set; }
        int Count { get; set; }
        void ChangeCount (int count);

    }
}
