using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class Engine
    {
        private float m_EnergyPercentage;

        public Engine(float i_CurrentSource, float i_MaxSourceCapacity)
        {
            this.m_EnergyPercentage = (i_CurrentSource/i_MaxSourceCapacity) * 100;
        }

        public float EnergyPercentage
        {
            get { return this.m_EnergyPercentage; }
        }
    }
}
