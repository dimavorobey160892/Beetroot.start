using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib
{
    public interface IShop
    {
        void RegisterNewProduct (IProduct product);
        void UpdateProductCount (int productId, int count);
        void SellProduct (int productId, int buyerId, int count);
        void RegisterBuyer (Buyer buyer);
    }
}
