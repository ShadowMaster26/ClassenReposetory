using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjarnesKids
{
    public class AllTypes
    {
        LandMethod();
    }

    public class Vehicle : AllTypes // Fuel : Engine : vehicleregion : vehicle
    {
        public string nameOneVehicle = "Vechicle";
    }

    //zones : vehicles
    public class Land : Vehicle
    {
        public void LandMethod()
        {
            Console.WriteLine("Land");
        }
    }

    public class Air : Vehicle
    {
        public string nameTwoAir = "Air";
    }

    public class Sea : Vehicle
    {
        public string nameTwoSea = "Sea";
    } 
    

    //engines : zones
    public class Engines : AllTypes
    {

    }

    public class EngineGas : Engines
    {
        public string enginetypeland = "Engine";
    }
    public class EngineAir : Land
    {
        public string enginetype = "Engine";
    }
    public class EngineSea : Land
    {
        public string enginetypeland = "Engine";
    }
}
