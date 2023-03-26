using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceLib.GearBox
{
    public class Automatic: GearBox
    {
        public override void AboutGearBox()
        {
            Console.WriteLine("This is Automatic");
        }
    }
}
