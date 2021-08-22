using System;

namespace Bridge.Platforms
{
    class DLive : IPlatform
    {
        public DLive()
        {
            ConfigureRMTP();
            Console.WriteLine("DLive: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("DLive: Auth Operation");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DLive: Configurando servidor RMTP.");
        }

    }
}
