namespace AbstractFactory.LandVehicles
{
    class Motorcycle : ILandVehicle
    {
        public void CheckList()
        {
            System.Console.WriteLine("Verificando calibragem dos pneus, colocando o capacete");
        }

        public void GetCargo()
        {
            System.Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            CheckList();
            GetCargo();
            System.Console.WriteLine("Iniciando a entrega.");
        }
    }
}
