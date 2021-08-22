using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    class LimeTransport : ITransportFactory
    {
        public ILandVehicle CreateLandVehicle()
        {
            return new Scooter();
        }

        public IAircrafts CreateAircraft()
        {
            return new Drone();
        }

    }
}
