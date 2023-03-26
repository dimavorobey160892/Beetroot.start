using AutoServiceLib;
using AutoServiceLib.Engine;
using AutoServiceLib.GearBox;
using AutoServiceLib.Vehicle;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var autoService = new AutoService();

            Vehicle v1 = new Car("blue", 5);
            Vehicle v2 = new Truck("green", 15);
            Vehicle v3 = new Van("blue", 2000);
            Vehicle v4 = new Bus("green", 40);
            Vehicle v5 = new Motocycle("blue", 2);
            Vehicle v6 = new Vehicle("green");

            autoService.Vehicles.Add(v1);
            autoService.Vehicles.Add(v2);
            autoService.Vehicles.Add(v3);
            autoService.Vehicles.Add(v4);
            autoService.Vehicles.Add(v5);
            autoService.Vehicles.Add(v6);
            foreach (var vehicle in autoService.Vehicles)
            {
                vehicle.About();
            }

            Engine engine1 = new Engine();
            Engine engine2 = new Gasoline();
            Engine engine3 = new Disel();
            Engine engine4 = new Electric();

            autoService.Engines.Add(engine1);
            autoService.Engines.Add(engine2);
            autoService.Engines.Add(engine3);
            autoService.Engines.Add(engine4);

            foreach (var engine in autoService.Engines)
            {
                engine.AboutEngine();
            }

            GearBox gearBox = new GearBox();
            GearBox gearBox1 = new Manual();
            GearBox gearBox2 = new Automatic();
            GearBox gearBox3 = new Robot();
            GearBox gearBox4 = new Variator();

            autoService.GearBoxes.Add(gearBox);
            autoService.GearBoxes.Add(gearBox1);
            autoService.GearBoxes.Add(gearBox2);
            autoService.GearBoxes.Add(gearBox3);
            autoService.GearBoxes.Add(gearBox4);

            foreach (var gearbox in autoService.GearBoxes)
            {
                gearbox.AboutGearBox();
            }
        }
    }
}