using System;

namespace Bridge.Platforms
{
    class Facebook : IPlatform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: Auth Operation");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando servidor RMTP.");
        }

    }
}
