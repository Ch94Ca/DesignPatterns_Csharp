using Adapter.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.PaymentProcessors
{
    class MercadoPago : IMercadoPago
    {
        public Token PaymentToken { get; set; }

        public Token AuthToken()
        {
            return new Token("d+56w2x7d1c1189");
        }

        public void SendMP()
        {
            PaymentToken = AuthToken();
            System.Console.WriteLine("Enviando pagamento com o MercadoPago.");
        }

        public void ReceiveMP()
        {
            System.Console.WriteLine("Recebendo o pagamento com o MercadoPago.");
        }
    }
}
