using System;

namespace Bridge.Platforms
{
    class Youtube : IPlatform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Auth Operation");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP.");
        }
    }
}
