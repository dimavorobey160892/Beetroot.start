namespace OnlineShopLib
{
    public class OnlineShop
    {
        private List <Accessories.Accessoies> accessories;
        private List <GamingConsol.GamingConsol> gamingConsols;
        private List <Notebook.Notebook> notebooks;
        private List <Smartphone.Smartphone> smartphones;
        private List <Buyer> buyers;
        private List <Receipt> receipts;

        public List <Accessories.Accessoies> Accessoies 
        { 
            get => accessories; set => accessories = value; 
        }
        public List <GamingConsol.GamingConsol> GamingConsols 
        {
            get => gamingConsols; set => gamingConsols = value; 
        }
        public List <Notebook.Notebook> Notebooks 
        {
            get => notebooks; set => notebooks = value; 
        }
        public List <Smartphone.Smartphone> Smartphones 
        {
            get => smartphones; set => smartphones = value; 
        }
        public List <Buyer> Buyers
        {
            get => buyers; set => buyers = value;
        }
        public List <Receipt> Receipts
        {
            get => receipts; set => receipts = value;
        }

        public OnlineShop()
        {
            vehicles = new List<Vehicle.Vehicle>();
            engines = new List<Engine.Engine>();
            gearboxes = new List<GearBox.GearBox>();
        }
    }
}