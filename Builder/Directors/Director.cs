using Builder.Builders;
using Builder.Components;
using Builder.Components.Enums;

namespace Builder.Directors
{
    class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedan()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(200));
            builder.SetTransmission(Transmission.AUTOMATIC);
            builder.SetSeats(5);
        }

        public void ConstructSportcar()
        {
            builder.SetVehicleType(VehicleType.SPORTCAR);
            builder.SetEngine(new Engine(900));
            builder.SetTransmission(Transmission.SEQUENTIAL_AUTOMATIC);
            builder.SetSeats(2);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(500));
            builder.SetTransmission(Transmission.MANUAL);
            builder.SetSeats(2);
        }

        public void ConstructPickuptruck()
        {
            builder.SetVehicleType(VehicleType.PICKUPTRUCK);
            builder.SetEngine(new Engine(400));
            builder.SetTransmission(Transmission.MANUAL);
            builder.SetSeats(2);
        }

        public void ConstructSUV()
        {
            builder.SetVehicleType(VehicleType.SUV);
            builder.SetEngine(new Engine(350));
            builder.SetTransmission(Transmission.SEQUENTIAL_AUTOMATIC);
            builder.SetSeats(6);
            builder.SetAirbagManufacturer(new Airbag(AirbagManufacturers.TAKATA));
        }

    }
}
