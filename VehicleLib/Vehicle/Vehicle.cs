namespace AutoServiceLib.Vehicle
{
    public class Vehicle
    {
        public Vehicle(string colour)
        {
            Colour = colour;
        }
        public string Colour { get; set; }
        public virtual void About()
        {
            Console.WriteLine($"Vehicle has {Colour} colour");
        }
    }
}