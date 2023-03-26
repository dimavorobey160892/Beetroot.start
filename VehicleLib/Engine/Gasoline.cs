using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceLib.Engine
{
    public class Gasoline: Engine
    {
        public override void AboutEngine()
        {
            Console.WriteLine("This is gassoline engine");
        }
    }
}
