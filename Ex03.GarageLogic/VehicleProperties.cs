using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal static class VehicleProperties
    {
        private static readonly Dictionary<eVehicleType, int> sr_NumOfWheelsDict = new Dictionary<eVehicleType, int>()
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

        private static readonly Dictionary<eVehicleType, float> sr_MaxWheelPSIDict = new Dictionary<eVehicleType, float>()
        {
            { eVehicleType.Truck, 26 },
            { eVehicleType.RegularCar, 33 },
            { eVehicleType.ElectricCar, 33 },
            { eVehicleType.RegularMotorcycle, 31 },
            { eVehicleType.ElectricMotorcycle, 31 },
        };

        private static readonly Dictionary<eVehicleType, float> sr_MaxEngineCapacity = new Dictionary<eVehicleType, float>()
        {
            { eVehicleType.Truck, 135f },
            { eVehicleType.RegularCar, 46 },
            { eVehicleType.ElectricCar, 5.2f },
            { eVehicleType.RegularMotorcycle, 6.4f },
            { eVehicleType.ElectricMotorcycle, 2.6f },
        };
    }
}
