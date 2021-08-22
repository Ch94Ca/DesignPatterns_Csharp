using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    class UberTransport : ITransportFactory
    {
        public ILandVehicle CreateLandVehicle()
        {
            return new Car();
        }

        public IAircrafts CreateAircraft()
        {
            return new Airplane();
        }
    }
}
