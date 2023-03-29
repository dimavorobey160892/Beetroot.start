namespace OnlineShopLib
{
    public class OnlineShop
    {
        private List<Product.Product> products;
        private List<Product.Accessories.Accessoies> accessories;
        private List<Product.GamingConsol.GamingConsol> gamingConsols;
        private List<Product.Notebook.Notebook> notebooks;
        private List<Product.Smartphone.Smartphone> smartphones;
        private List<Buyer> buyers;
        private List<Receipt> receipts;

        public List <Product.Product> Products
        {
            get => products; set => products = value;
        }
        public List<Product.Accessories.Accessoies> Accessoies
        {
            get => accessories; set => accessories = value;
        }
        public List<Product.GamingConsol.GamingConsol> GamingConsols
        {
            get => gamingConsols; set => gamingConsols = value;
        }
        public List<Product.Notebook.Notebook> Notebooks
        {
            get => notebooks; set => notebooks = value;
        }
        public List<Product.Smartphone.Smartphone> Smartphones
        {
            get => smartphones; set => smartphones = value;
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
            products = new List<Product.Product>();
            accessories = new List<Product.Accessories.Accessoies>();
            gamingConsols = new List<Product.GamingConsol.GamingConsol>();
            notebooks = new List<Product.Notebook.Notebook>();
            smartphones = new List<Product.Smartphone.Smartphone>();
            buyers = new List<Buyer>();
            receipts = new List<Receipt>();

        }
    }
}