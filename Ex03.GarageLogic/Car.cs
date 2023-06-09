﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Car : Vehicle
    {
        private readonly eCarColor r_CarColor;
        private readonly eCarDoors r_CarDoors;

        public Car(string i_ModelName, string i_LicensePlate, Engine i_Engine,
                          List<Wheel> i_Wheels, eCarColor i_CarColor, eCarDoors i_CarDoors)
            : base (i_ModelName, i_LicensePlate, i_Engine, i_Wheels)
        {
            this.r_CarColor = i_CarColor;
            this.r_CarDoors = i_CarDoors; 
        }

        public eCarColor CarColor 
        { 
            get { return this.r_CarColor; } 
        }    

        public eCarDoors CarDoors
        {
            get { return this.r_CarDoors; }
        }

    }
}
