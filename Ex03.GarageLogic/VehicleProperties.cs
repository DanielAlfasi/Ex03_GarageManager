using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal static class VehicleProperties
    {
        private static readonly Dictionary<eVehicleType, int> sr_WheelsDict = new Dictionary<eVehicleType, int>()
        {
            { eVehicleType.Truck, 14 },
            { eVehicleType.ElectricCar, 5 },
            { eVehicleType.RegularCar, 5 },
            { eVehicleType.ElectricMotorcycle, 2 },
            { eVehicleType.RegularMotorcycle, 2 },
        };

        private static readonly Dictionary<eVehicleType, eFuelType> sr_FuelTypeDict = new Dictionary<eVehicleType, eFuelType>()
        {
            { eVehicleType.Truck, eFuelType.Soler },
            { eVehicleType.RegularCar, eFuelType.Octan95 },
            { eVehicleType.RegularMotorcycle, eFuelType.Octan98 },
        };
    }
}
