using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class VehicleGenerator
    {
        public static Vehicle GenerateNewVehicle(string i_ModelName, string i_LicensePlate, eVehicleType i_VehicleType)
        {
            Vehicle vehicle;
            Engine engine = generateEngine(i_VehicleType);
            Wheel[] wheels = generateWheel(i_VehicleType);

            switch (i_VehicleType)
            {
                case eVehicleType.ElectricCar:
                    vehicle = new ElectricCar();
                    break;

                case eVehicleType.RegularCar:
                    vehicle = new RegularCar();
                    break;

                case eVehicleType.ElectricMotorcycle:
                    vehicle = new ElectricMotorcycle();
                    break;

                case eVehicleType.RegularMotorcycle:
                    vehicle = new RegularMotorcycle();
                    break;

                case eVehicleType.Truck:
                    vehicle = new Truck(i_ModelName, i_LicensePlate, wheels,);
                    break;

                default:
                    vehicle = null;
                    break;
            }

            return vehicle;
        } 

        private static Wheel[] generateWheel(eVehicleType i_VehicleType)
        {
            Wheel[] wheels = new Wheel[VehicleProperties.sr_NumOfWheelsDict[i_VehicleType]];

            for (int i = 0; i < wheels.Length; i++)
            {
                //  add ManufacturerName, MaxWheelPSI, CurrentPSI to the wheel ctor 
                wheels[i] = new Wheel();
            }

            return wheels;
        }

        private static Engine generateEngine(eVehicleType i_VehicleType)
        {
            Engine engine = null;

            if (i_VehicleType == eVehicleType.ElectricCar || i_VehicleType == eVehicleType.ElectricMotorcycle)
            {
                // add CurrentBatteryLife, MaxBatteryLife to engine electric ctor
                engine = new ElectricEngine();
           
            }
            else if (i_VehicleType == eVehicleType.RegularCar || i_VehicleType == eVehicleType.RegularMotorcycle || i_VehicleType == eVehicleType.Truck)
            {
                // add FuelType, CurrentFuel, MaxFuelCapacity to engine fuel ctor
                engine = new FuelEngine();
            }

            return engine;

        }
    }
}
