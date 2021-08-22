namespace AbstractFactory.Aircrafts
{
    class Airplane : IAircrafts
    {
        public void Checklist()
        {
            System.Console.WriteLine("Tempo ideal para voo. Verificando o tanque de combustível");
        }

        public void GetCargo()
        {
            System.Console.WriteLine("Pegamos as encomendas.");
        }

        public void StartRoute()
        {
            Checklist();
            GetCargo();
            System.Console.WriteLine("Iniciando o voo.");
        }
    }
}
