using Factory.Factories;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;
            string service = "--eats";

            if(service.Length > 0)
            {
                if (service == "--uber")
                {
                    transport = new CarTransport();
                }
                else if (service == "--log")
                {
                    transport = new MotorcycleTransport();
                }
                else if (service == "--eats")
                {
                    transport = new BikeTransport();
                }

                if (transport != null)
                {
                    transport.StartTransport();
                }

            }
            else
            {
                Console.WriteLine("Selecione o tipo do serviço.");
            }

            Console.ReadLine();

        }
    }
}
