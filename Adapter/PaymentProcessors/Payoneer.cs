using Adapter.Entities;
using System;

namespace Adapter.PaymentProcessors
{
    class Payoneer : IPayoneerPayment
    {
        public Token PaymentToken { get; set; }

        public Token AuthToken()
        {
            return new Token("d+56w2x7d1189");
        }

        public void SendPayment()
        {
            PaymentToken = AuthToken();
            System.Console.WriteLine("Enviando pagamento com o Payoneer.");
        }

        public void ReceivePayment()
        {
            System.Console.WriteLine("Recebendo o pagamento com o Payoneer.");
        }
    }
}
