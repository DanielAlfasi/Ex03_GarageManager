using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Wheel
    {
        private readonly string r_ManufacturerName;
        private readonly float r_MaxWheelPSI;
        private float m_CurrentPSI;

        public Wheel(string i_ManufacturerName, float i_MaxWheelPSI, float i_CurrentPSI)
        {
            this.r_ManufacturerName = i_ManufacturerName;
            this.r_MaxWheelPSI = i_MaxWheelPSI;
            this.m_CurrentPSI = i_CurrentPSI;
        }

        public string ManufacturerName
        {
            get { return this.r_ManufacturerName; }
        }

        public float MaxWheelPSI
        {
            get { return this.MaxWheelPSI; }
        }

        public float CurrentPSI
        {
            get { return this.m_CurrentPSI; }
        }

        public bool AddAir(float i_AddAirToInflate)
        {
            bool isValidInflate = false;

            if(i_AddAirToInflate > 0 && i_AddAirToInflate + this.m_CurrentPSI <= this.r_MaxWheelPSI)
            {
                this.m_CurrentPSI += i_AddAirToInflate;
                isValidInflate = true;
            }
            return isValidInflate;
        }
    }
}
