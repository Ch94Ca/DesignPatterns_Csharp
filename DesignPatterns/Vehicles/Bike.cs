using System;

namespace Factory.Vehicles
{
    class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a comida.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega.");
        }
    }
}
