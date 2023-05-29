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

        public float CurrentBatteryLife
        {
            get { return this.m_CurrentBatteryLife; }
        }

        public float MaxBatteryLife
        {
            get { return this.r_MaxBatteryLife;  }
        }
        public bool ChargeBattery(float i_TimeToCharge)
        {
            bool isCharged = true;
            if (i_TimeToCharge + this.m_CurrentBatteryLife > this.r_MaxBatteryLife || i_TimeToCharge < 0)
            {
                isCharged = false;
            }
            else
            {
                this.m_CurrentBatteryLife += i_TimeToCharge;
            }
            return isCharged;
        }

    }
}
