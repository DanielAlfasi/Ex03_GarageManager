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
        private readonly Engine r_Engine;
        private readonly List<Wheel> r_Wheels;

        public Vehicle(string i_ModelName, string i_LicensePlate, Engine i_Engine, List<Wheel> i_Wheels)
        {
            this.r_ModelName = i_ModelName;
            this.r_LicensePlate = i_LicensePlate;
            this.r_Engine = i_Engine;
            this.r_Wheels = i_Wheels;
        }

        public bool AddAirToWheels(float i_AirToInflate)
        {
            bool isValidInflate = true;

            foreach(Wheel wheel in this.r_Wheels)
            {
                if (!(wheel.AddAir(i_AirToInflate)))
                {
                    isValidInflate = false; 
                    break;
                }
            }
            return isValidInflate;
        }

        public string ModelName
        {
            get { return this.r_ModelName; }
        }

        public string LicensePlate
        {
            get { return this.LicensePlate; }
        }

        public Engine Engine 
        { 
            get { return this.r_Engine;} 
        }

        public List<Wheel> Wheels
        {
            get { return this.r_Wheels; }
        }
    }
}
