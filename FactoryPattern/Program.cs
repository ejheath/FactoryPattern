using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Enter wheel count for either car or motorcycle: ")

                input = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();
        }

    }
}