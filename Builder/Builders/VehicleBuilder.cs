using Builder.Components;
using Builder.Components.Enums;
using Builder.Products;

namespace Builder.Builders
{
    class VehicleBuilder : IBuilder
    {
        public Vehicle Vehicle { get; set; } = new Vehicle();
        public Vehicle GetVehicle()
        {
            Vehicle result = Vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            Vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine)
        {
            Vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            Vehicle.Seats = seats;
        }

        public void SetTransmission(Transmission transmission)
        {
            Vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            Vehicle.VehicleType = vehicleType;
        }

        public void SetAirbagManufacturer(Airbag airbag)
        {
            Vehicle.Airbag = airbag;
        }
    }
}
