using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Vehicles
{
    class Motorcycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega.");
        }
    }
}
