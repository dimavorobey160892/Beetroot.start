namespace OnlineShopLib
{
    public class OnlineShop : IShop
    {
        private List<IProduct> products;
        private List<Buyer> buyers;
        private List<Receipt> receipts;

        public List <IProduct> Products
        {
            get => products; set => products = value;
        }
        
        public List<Buyer> Buyers
        {
            get => buyers; set => buyers = value;
        }
        public List<Receipt> Receipts
        {
            get => receipts; set => receipts = value;
        }

        public OnlineShop()
        {
            products = new List<IProduct>();
            buyers = new List<Buyer>();
            receipts = new List<Receipt>();

        }
        public void RegisterNewProduct(IProduct product)
        {
            products.Add(product);
        }

        public void UpdateProductCount(int productId, int count)
        {
            foreach (var prod in products)
            {
                if ( prod.Id == productId)
                {
                    prod.Count = count;
                }
            }
        }
        public void SellProduct(int productId, int buyerId, int count)
        {
            var product = products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                var receipt = new Receipt
                {
                    Id = receipts.Max(x => x.Id) + 1,
                    date = DateTime.Now,
                    product = product,
                    buyer = buyers.FirstOrDefault(p => p.Id == buyerId),
                };
                receipts.Add(receipt);
                UpdateProductCount(productId, product.Count - count);
            }
        }
        public void RegisterBuyer(Buyer buyer)
        {
            buyers.Add(buyer);
        }
    }
}