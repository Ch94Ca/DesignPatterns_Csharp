using System;
using AbstractFactory.App;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("99: ");
            Application app99 = ConfigureApplication("99");
            app99.StartRoute();

            System.Console.WriteLine("\nUber:");
            Application appUber = ConfigureApplication("uber");
            appUber.StartRoute();

            System.Console.WriteLine("\nLime:");
            Application appLime = ConfigureApplication("lime");
            appLime.StartRoute();
        }

        static Application ConfigureApplication(string company)
        {
            ITransportFactory transportFactory = null;

            if (company == "uber")
            {
                transportFactory = new UberTransport();
            }
            else if (company == "99")
            {
                transportFactory = new NineNineTransport();
            }
            else if(company == "lime")
            {
                transportFactory = new LimeTransport();
            }

            return new Application(transportFactory);
        }
    }
}
