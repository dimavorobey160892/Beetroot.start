namespace OnlineShopLib
{
    public class OnlineShop
    {
        private List <Accessories.Accessoies> accessories;
        private List <GamingConsol.GamingConsol> gamingConsols;
        private List <Notebook.Notebook> notebooks;
        private List<Smartphone.Smartphone> smartphones;
        public List<Accessories.Accessoies> Accessoies { get => accessories; set => vehicles = value; }
        public List<Engine.Engine> Engines { get => engines; set => engines = value; }
        public List<GearBox.GearBox> GearBoxes { get => gearboxes; set => gearboxes = value; }
        public AutoService()
        {
            vehicles = new List<Vehicle.Vehicle>();
            engines = new List<Engine.Engine>();
            gearboxes = new List<GearBox.GearBox>();
        }
    }
}