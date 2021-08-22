using System;
using ChainOfResponsibility.Servers;

namespace ChainOfResponsibility.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        public Server Server { get; set; }

        public CheckUserMiddleware(Server server)
        {
            Server = server;
        }

        public override bool Check(string email, string password)
        {
            if(!Server.HasEmail(email))
            {
                Console.WriteLine("Email inválido.");
                return false;
            }

            if(!Server.IsValidPassword(email, password))
            {
                Console.WriteLine("Email e/ou senha inválidos.");
                return false;
            }

            return CheckNext(email, password);

        }
    }
}
