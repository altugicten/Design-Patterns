using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicle
    {
        void Drive();
        void Park();
        void Stop();
    }

    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }

        public void Park()
        {
            Console.WriteLine("Parking a car");
        }

        public void Stop()
        {
            Console.WriteLine("A car is stopped");
        }
    }

    class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck");
        }

        public void Park()
        {
            Console.WriteLine("Parking a truck");
        }

        public void Stop()
        {
            Console.WriteLine("A truck is stopped");
        }

    }

    class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a motorcycle");
        }

        public void Park()
        {
            Console.WriteLine("Parking a motorcycle");
        }

        public void Stop()
        {
            Console.WriteLine("A motorcycle is stopped");
        }
    }
}
