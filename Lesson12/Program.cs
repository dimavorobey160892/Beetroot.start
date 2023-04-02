using OnlineShopLib;
using System.Diagnostics;

namespace Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineShop OnlineShop = new OnlineShop();
            string command = "";
            do
            {
                Console.WriteLine("Welcom to our OnlineShop!");
                Console.WriteLine("1 - add new product");
                Console.WriteLine("2 - update product count");
                Console.WriteLine("3 - sell product");
                Console.WriteLine("4 - register buyer");
                Console.WriteLine("5 - print products");
                Console.WriteLine("6 - print buyers");
                Console.WriteLine("For close enter Exit");
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":

                        Console.WriteLine("Enter name");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter price");
                        int price = 0;
                        Int32.TryParse(Console.ReadLine(), out price);

                        Console.WriteLine("Enter count");
                        int count = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" Which product do you want to add?");
                        Console.WriteLine("a - accessories");
                        Console.WriteLine("b - gaming console");
                        Console.WriteLine("c - laptop");
                        Console.WriteLine("d - smartphone");
                        string choice = Console.ReadLine();
                        var MaxProdID = OnlineShop.Products.Count;
                        switch (choice)
                        {
                            case "a":
                                Console.WriteLine("Enter type of accessory");
                                string typeOfAccessories = Console.ReadLine();
                                IProduct accsessory = new Accessories(MaxProdID + 1, name, price, count, typeOfAccessories);
                                OnlineShop.RegisterNewProduct(accsessory);
                                break;
                            case "b":
                                Console.WriteLine("Enter brand of console");
                                string brand = Console.ReadLine();
                                IProduct console = new GamingConsol(MaxProdID + 1, name, price, count, brand);
                                OnlineShop.RegisterNewProduct(console);
                                break;
                            case "c":
                                Console.WriteLine("Enter type of laptop");
                                string type = Console.ReadLine();
                                IProduct laptop = new Laptop(MaxProdID + 1, name, price, count, type);
                                OnlineShop.RegisterNewProduct(laptop);
                                break;
                            case "d":
                                Console.WriteLine("Enter operation system");
                                string os = Console.ReadLine();
                                IProduct operSyst = new SmartPhone(MaxProdID + 1, name, price, count, os);
                                OnlineShop.RegisterNewProduct(operSyst);
                                break;
                        }
                        Console.WriteLine("Product added");                     
                        break;

                    case "2":
                        Console.WriteLine("Enter product ID");
                        int prodId =Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter count");
                        int prodCount = Convert.ToInt32(Console.ReadLine());
                        OnlineShop.UpdateProductCount(prodId, prodCount);
                        break;

                    case "3":
                        Console.WriteLine("Enter product ID");
                        int prodid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter count");
                        int prodcount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter buyer's ID");
                        int buyerId = Convert.ToInt32(Console.ReadLine());
                        OnlineShop.SellProduct(prodid, buyerId, prodcount);
                        break;

                    case "4":
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        int maxId = OnlineShop.Buyers.Count;
                        Buyer buyer = new Buyer
                        {
                            Id = maxId + 1,
                            FirstName = firstName,
                            LastName = lastName
                        };
                        OnlineShop.RegisterBuyer (buyer);
                    break;

                    case "5":
                        foreach (Product pr in OnlineShop.Products)
                        {
                            pr.Print();
                        }
                    break; 

                    case "6":
                        foreach (Buyer br in OnlineShop.Buyers)
                        {
                            Console.WriteLine($" Id = {br.Id}, {br.FullName}");
                        }
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            } while (command != "Exit");

        }
    }
}