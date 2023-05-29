using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ElectricEngine : Engine
    {
        private float m_CurrentBatteryLife;
        private readonly float r_MaxBatteryLife;

        public ElectricEngine(float i_CurrentBatteryLife, float i_MaxBatteryLife) : base(i_CurrentBatteryLife, i_MaxBatteryLife)
        {
            this.m_CurrentBatteryLife = i_CurrentBatteryLife;
            this.r_MaxBatteryLife = i_MaxBatteryLife;
        }

        public bool ChargeBattery(float i_TimeToCharge)
        {
            // TODO 
            return true;
        }

    }
}
