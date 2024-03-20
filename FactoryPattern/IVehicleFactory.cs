using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }

    class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            Car car = new Car();
            return car;
        }
    }

    class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            Truck truck = new Truck();
            return truck;
        }
    }

    class MotorFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            Motorcycle motorcycle = new Motorcycle();
            return motorcycle;
        }
    }
}
