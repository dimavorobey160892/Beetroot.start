using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoServiceLib
{
    public class AutoService
    {
        private List<Vehicle.Vehicle> vehicles;
        private List<Engine.Engine> engines;
        private List<GearBox.GearBox> gearboxes;
        public List<Vehicle.Vehicle> Vehicles { get => vehicles; set => vehicles = value; }
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
