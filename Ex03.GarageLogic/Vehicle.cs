using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class Vehicle
    {
        private readonly string r_ModelName;
        private readonly string r_LicensePlate;
        private float m_EnergyPercentage;
        private readonly List<Wheel> r_Wheels;

        public bool AddAirToWheels(float i_AirToInflate)
        {
            //To Impelemnt 
            return true;
        }

        public eVehicleStatus GetStatus()
        {
            // To be decided
            return eVehicleStatus.Inrepair;
        }
       

    }
}
