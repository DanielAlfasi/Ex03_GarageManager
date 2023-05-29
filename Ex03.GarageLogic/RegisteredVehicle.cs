using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class RegisteredVehicle
    {
        private readonly Vehicle r_Vehicle;
        private readonly string r_OwnerName;
        private readonly string r_OwnerPhoneNumber;
        private eVehicleStatus m_VehicleStatus;

        public eVehicleStatus VehicleStatus
        {
            get { return m_VehicleStatus; } 
        }

        public void UpdateStatus(eVehicleStatus i_StatusToUpdate)
        {
            this.m_VehicleStatus = i_StatusToUpdate;
        }
    }
}
