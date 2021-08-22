using Builder.Components;
using Builder.Components.Enums;

namespace Builder.Products
{
    class Vehicle
    {
        public VehicleType VehicleType { get; set; }
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public int Seats { get; set; }
        public Airbag Airbag { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(VehicleType vehicleType, Engine engine, Transmission transmission, Airbag airbag, int seats)
        {
            VehicleType = vehicleType;
            Engine = engine;
            Transmission = transmission;
            Airbag = airbag;
            Seats = seats;
        }
    }
}
