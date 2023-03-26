using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceLib.Vehicle
{
    public class Truck: Vehicle
    {
        public int Lenght { get; set; }
        public Truck (string colour, int lenght) : base(colour)
        {
            Lenght = lenght;
        }

        public override void About()
        {
            Console.WriteLine($"Track has {Colour} colour and lenght has {Lenght}");
        }
    }
}
