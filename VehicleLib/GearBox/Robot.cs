using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceLib.GearBox
{
    public class Robot: GearBox
    {
        public override void AboutGearBox()
        {
            Console.WriteLine("This is Robot Gear Box");
        }
    }
}
