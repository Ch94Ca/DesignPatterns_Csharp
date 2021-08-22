using Factory.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories
{
    class MotorcycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
