using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceLib.Vehicle
{
    public class Motocycle: Vehicle
    {
        public int WheelCount { get; set; }
        public Motocycle (string colour, int count) : base(colour)
        {
            WheelCount = count;
        }

        public override void About()
        {
            Console.WriteLine($"Motocycle has {Colour} colour and {WheelCount} wheels ");
        }
    }
}
