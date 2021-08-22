using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    class NineNineTransport : ITransportFactory
    {
        public ILandVehicle CreateLandVehicle()
        {
            return new Motorcycle();
        }

        public IAircrafts CreateAircraft()
        {
            return new Helicopter();
        }
    }
}

