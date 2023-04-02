using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopLib
{
    abstract public class Product : IProduct
    {
        private int count;
        public int Id { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public int Count 
        {
            get
            {
                return count;
            }
            set
            {
                if (value > 0)
                {
                    count = value;
                }
            }
        }
        public void ChangeCount(int count)
        {
            Count = count;
        }
        public Product(int id, string name, int price, int count)
        {
            Id = id;
            Name = name;
            Price = price;
            Count = count;
        }
        public abstract void About();

        public void Print()
        {
            Console.WriteLine($"id = {Id}, name = {Name}, price = {Price}, count = {Count}");
            About();
        }
    }
}
