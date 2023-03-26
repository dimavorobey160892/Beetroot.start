using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceLib.Vehicle
{
    public class Car: Vehicle
    {
        public int DoorCount { get; set; }
        public Car(string colour, int doorCount) : base(colour)
        {
            DoorCount = doorCount;
        }

        public override void About()
        {
            Console.WriteLine($"Car has {Colour} colour and {DoorCount} doors ");
        }
    }
}
