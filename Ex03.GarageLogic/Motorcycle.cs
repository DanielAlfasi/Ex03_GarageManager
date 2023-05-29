using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Motorcycle : Vehicle
    {
        private readonly eMotorcycleLicense r_MotorcycleLicense;
        private readonly int r_EngineVolume;

        public Motorcycle(string i_ModelName, string i_LicensePlate, Engine i_Engine,
                          List<Wheel> i_Wheels, eMotorcycleLicense i_MotorcycleLicense, int i_EngineVolume)
            : base(i_ModelName, i_LicensePlate, i_Engine, i_Wheels)
        {
            this.r_MotorcycleLicense = i_MotorcycleLicense;
            this.r_EngineVolume = i_EngineVolume;
        }

        public eMotorcycleLicense MotorcycleLicense
        {
            get { return this.r_MotorcycleLicense; }
        }

        public int EngineVolume
        {
            get {  return this.r_EngineVolume; }
        }


    }
}
