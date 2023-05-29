using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Truck : Vehicle
    {
        private readonly bool r_IsCarryingDangerousGoods;
        private readonly float r_CargoVolume;
        private readonly FuelEngine r_Engine;
    }
}
