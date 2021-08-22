using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedan();
            Vehicle sedan = builder.GetVehicle();
            Console.WriteLine($"{sedan.VehicleType} criado.");

            director.ConstructSportcar();
            Vehicle sportCar = builder.GetVehicle();
            Console.WriteLine($"{sportCar.VehicleType} criado.");

            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();
            Console.WriteLine($"{truck.VehicleType} criado.");

            director.ConstructPickuptruck();
            Vehicle pickupTruck = builder.GetVehicle();
            Console.WriteLine($"{pickupTruck.VehicleType} criado.");

            director.ConstructSUV();
            Vehicle SUV = builder.GetVehicle();
            Console.WriteLine($"{SUV.VehicleType} criado.");

        }
    }
}
