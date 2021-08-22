using System;
using System.Collections.Generic;
using ChainOfResponsibility.Middlewares;

namespace ChainOfResponsibility.Servers
{
    class Server
    {
        public Dictionary<string, string> Users { get; set; } = new Dictionary<string, string>();
        public Middleware Middleware { get; set; }

        public void SetMiddleware(Middleware middleware)
        {
            Middleware = middleware;
        }

        public bool LogIn(string email, string password)
        {
            if (Middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso.");
                Console.WriteLine("Seja bem vindo.");
                return true;
            }

            return false;
        }

        public void RegisterUser(string email, string password)
        {
            Users[email] = password;
        }

        public bool HasEmail(string email)
        {
            return Users.ContainsKey(email);
        }

        public bool IsValidPassword(string email, string password)
        {
            string value;

            Users.TryGetValue(email, out value);

            return value == password;
        }

    }
}
