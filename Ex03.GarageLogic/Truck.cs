﻿using System;
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

        public Truck(string i_ModelName, string i_LicensePlate, Engine i_Engine,
                          List<Wheel> i_Wheels, bool r_IsCarryingDangerousGoods, float r_CargoVolume, FuelEngine i_FuelEngine)
            : base(i_ModelName, i_LicensePlate, i_Engine, i_Wheels)
        {
            this.r_IsCarryingDangerousGoods = r_IsCarryingDangerousGoods;
            this.r_CargoVolume = r_CargoVolume;
        }

        public bool IsCarryingDangerousGoods
        {
            get { return this.r_IsCarryingDangerousGoods; }
        }

        public float CargoVolume
        {
            get { return this.r_CargoVolume; }
        }
    }
}
