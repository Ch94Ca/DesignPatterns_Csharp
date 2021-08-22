namespace AbstractFactory.LandVehicles
{
    class Scooter : ILandVehicle
    {
        public void CheckList()
        {
            System.Console.WriteLine("Verificando a bateria do patinete, colocando o capacete");
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
