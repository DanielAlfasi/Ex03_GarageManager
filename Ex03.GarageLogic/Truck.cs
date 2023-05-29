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

        public Truck(string i_ModelName, string i_LicensePlate, EnergySource i_EnergySource,
                          List<Wheel> i_Wheels, bool r_IsCarryingDangerousGoods, float r_CargoVolume, FuelEngine i_FuelEngine)
            : base(i_ModelName, i_LicensePlate, i_EnergySource, i_Wheels)
        {
            this.r_IsCarryingDangerousGoods = r_IsCarryingDangerousGoods;
            this.r_CargoVolume = r_CargoVolume;
        }
    }
}
