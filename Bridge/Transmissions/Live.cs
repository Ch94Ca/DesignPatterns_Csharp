using Bridge.Platforms;

namespace Bridge.Transmissions
{
    class Live : ITransmission
    {
        public IPlatform Platform { get; set; }

        public Live(IPlatform platform)
        {
            Platform = platform;
        }

        public void Broadcast()
        {
            System.Console.WriteLine($"Iniciando transmissão em {Platform}");
        }

        public void Result()
        {
            System.Console.WriteLine("**** On Air ****");
        }
    }
}
