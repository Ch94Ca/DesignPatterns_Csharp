using System;
using ChainOfResponsibility.Servers;

namespace ChainOfResponsibility.Middlewares
{
    class CheckPermisionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if(email.Equals("root@mail.com.br"))
            {
                Console.WriteLine("Seja bem-vindo administrador");
                return true;
            }

            Console.WriteLine("Seja bem vindo.");

            return CheckNext(email, password);

        }
    }
}
