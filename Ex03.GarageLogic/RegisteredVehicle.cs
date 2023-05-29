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

        public RegisteredVehicle(Vehicle i_Vehicle, string i_OwnerName, string i_OwnerIdPhoneNumber)
        {
            this.r_Vehicle = i_Vehicle;
            this.r_OwnerName = i_OwnerName;
            this.r_OwnerPhoneNumber = i_OwnerIdPhoneNumber;
            this.m_VehicleStatus = eVehicleStatus.Inrepair;
        }

        public Vehicle Vehicle
        {
            get { return this.r_Vehicle; }
        }

        public string OwnerName
        {
            get { return this.r_OwnerName; }
        }

        public string OwnerPhoneNumber
        {
            get { return this.r_OwnerPhoneNumber; }
        }

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
