using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {
        IAircrafts CreateAircraft();
        ILandVehicle CreateLandVehicle();

    }
}
