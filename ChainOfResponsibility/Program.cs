using System;
using ChainOfResponsibility.Middlewares;
using ChainOfResponsibility.Servers;
namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            init();

            bool done = false;

            do
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                done = server.LogIn(email, password);

            } while (!done);
        }

        private static Server server;

        static void init()
        {
            server = new Server();

            server.RegisterUser("root@mail.com", "123456");
            server.RegisterUser("user@mail.com", "abcdef");

            Middleware middleware = new CheckUserMiddleware(server);
            middleware.LinkWith(new CheckPermisionMiddleware());
            middleware.LinkWith(new CheckWeakPassword());
            server.SetMiddleware(middleware);

        } 
    }
}
