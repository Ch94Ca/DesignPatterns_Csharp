namespace AbstractFactory.Aircrafts
{
    class Drone : IAircrafts
    {
        public void Checklist()
        {
            System.Console.WriteLine("Tempo ideal para voo. Verificando bateria do drone.");
        }

        public void GetCargo()
        {
            System.Console.WriteLine("Pegamos o pacote.");
        }

        public void StartRoute()
        {
            Checklist();
            GetCargo();
            System.Console.WriteLine("Iniciando o voo de entrega.");
        }

    }
}
