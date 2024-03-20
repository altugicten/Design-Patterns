using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicleCreator
    {
        IVehicle CreateVehicleForFactory(VehicleEnum type);
        IVehicle CreateVehicleForFactoryMethod(VehicleEnum type);
    }


    class VehicleCreator : IVehicleCreator
    {
        public IVehicle CreateVehicleForFactory(VehicleEnum type)
        {
            IVehicle _vehicle = null;

            switch (type)
            {
                case VehicleEnum.Car:
                    _vehicle = new Car();
                    break;
                case VehicleEnum.Truck:
                    _vehicle = new Truck();
                    break;
                case VehicleEnum.Motor:
                    _vehicle = new Motorcycle();
                    break;
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }

            return _vehicle;
        }

        public IVehicle CreateVehicleForFactoryMethod(VehicleEnum type)
        {
            IVehicleFactory _vehicle = type switch
            {
                VehicleEnum.Car => new CarFactory(),
                VehicleEnum.Truck => new TruckFactory(),
                VehicleEnum.Motor => new MotorFactory(),
            };

            return _vehicle.CreateVehicle();
        }
    }


    //class CarFactory : IVehicleFactory
    //{
    //    public IVehicle CreateVehicle()
    //    {
    //        return new Car();
    //    }
    //}

    //class TruckFactory : IVehicleFactory
    //{
    //    public IVehicle CreateVehicle()
    //    {
    //        return new Truck();
    //    }
    //}

    //class MotorcycleFactory : IVehicleFactory
    //{
    //    public IVehicle CreateVehicle()
    //    {
    //        return new Motorcycle();
    //    }
    //}
}
