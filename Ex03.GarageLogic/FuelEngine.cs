using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class FuelEngine : Engine
    {
        private readonly eFuelType r_FuelType;
        private float m_CurrentFuel;
        private readonly float m_MaxFuelCapacity;

        public FuelEngine(eFuelType i_FuelType, float i_CurrentFuel, float i_MaxFuelCapacity) : base(i_CurrentFuel, i_MaxFuelCapacity)
        {
            this.r_FuelType = i_FuelType;
            this.m_CurrentFuel = i_CurrentFuel;
            this.m_MaxFuelCapacity = i_MaxFuelCapacity;
        }

        public bool FuelVehicle(float i_LitersToFuel, eFuelType i_FuelType)
        {
            // TODO
            return true;
        }
    }
}
