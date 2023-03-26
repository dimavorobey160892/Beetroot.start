using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceLib.Vehicle
{
    public class Van: Vehicle
    {
        public int MaxWeight { get; set; }
        public Van(string colour, int weight) : base(colour) 
        {
            MaxWeight = weight;
        }

        public override void About()
        {
            Console.WriteLine($"Van has {Colour} colour and weight has {MaxWeight}");
        }
    }
}
