namespace AbstractFactory.LandVehicles
{
    class Car : ILandVehicle
    {
        public void CheckList()
        {
            System.Console.WriteLine("Verificando calibragem dos pneus, colocando o cinto de segurança");
        }

        public void GetCargo()
        {
            System.Console.WriteLine("Pegamos os passageiros");
        }

        public void StartRoute()
        {
            CheckList();
            GetCargo();
            System.Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
