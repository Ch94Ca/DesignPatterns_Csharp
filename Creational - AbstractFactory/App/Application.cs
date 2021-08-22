using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;
using AbstractFactory.Factories;

namespace AbstractFactory.App
{
    class Application
    {
        private IAircrafts aircraft;
        private ILandVehicle vehicle;

        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateAircraft();
            vehicle = factory.CreateLandVehicle();
        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }

    }
}
