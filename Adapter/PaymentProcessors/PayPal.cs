using Adapter.Entities;

namespace Adapter.PaymentProcessors
{
    class PayPal : IPaypalPayment
    {
        public Token PaymentToken { get; set; }

        public Token AuthToken()
        {
            return new Token("d+56w17d189");
        }

        public void PayPalPayment()
        {
            PaymentToken = AuthToken();
            System.Console.WriteLine("Enviando pagamento com o PayPal.");
        }

        public void PayPalReceive()
        {
            System.Console.WriteLine("Recebendo o pagamento com o Paypal.");
        }
    }
}
