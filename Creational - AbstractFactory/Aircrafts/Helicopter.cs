namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircrafts
    {
        public void Checklist()
        {
            System.Console.WriteLine("Tempo ideal para voo. Verificando hélices");
        }

        public void GetCargo()
        {
            System.Console.WriteLine("Pegamos os passageiros.");
        }

        public void StartRoute()
        {
            Checklist();
            GetCargo();
            System.Console.WriteLine("Iniciando o voo.");
        }
    }
}
