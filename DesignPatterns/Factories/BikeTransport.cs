using Factory.Vehicles;

namespace Factory.Factories
{
    class BikeTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
