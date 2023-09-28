using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjarnesKids
{
    public class AllTypes
    {
        public void Run()
        {

        }
    }

    public class Vehicle : AllTypes
    {

    }


    public class Land : Vehicle
    {

    }

    public class Air : Vehicle
    {

    }

    public class Sea : Vehicle
    {

    } 
    

    //engines : zones
    public class Engines : AllTypes
    {

    }

    public class EngineGas : Engines
    {

    }
    public class EngineAir : Land
    {

    }
    public class EngineSea : Land
    {

    }
}
