using System;

namespace Bridge.Platforms
{
    class TwitchTv : IPlatform
    {
        public TwitchTv()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTv: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("TwitchTv: Auth Operation");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTv: Configurando servidor RMTP.");
        }

    }
}
