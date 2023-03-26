using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceLib.Vehicle
{
    public class Bus: Vehicle
    {
        public int PassangerCount { get; set; }
        public Bus(string colour, int passengerCount) : base(colour)
        {
            PassangerCount = passengerCount;
        }

        public override void About()
        {
            Console.WriteLine($"Bus has {Colour} colour and {PassangerCount} seats ");
        }
    }
}
