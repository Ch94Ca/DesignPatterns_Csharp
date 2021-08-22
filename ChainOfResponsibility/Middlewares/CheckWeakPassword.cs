using ChainOfResponsibility.Servers;

namespace ChainOfResponsibility.Middlewares
{
    class CheckWeakPassword : Middleware
    {
        public override bool Check(string email, string password)
        {
            if(password.Equals("123456"))
            {
                System.Console.WriteLine("Recomendamos que a senha atual seja alterada.");
            }

            return CheckNext(email, password);

        }
    }
}
