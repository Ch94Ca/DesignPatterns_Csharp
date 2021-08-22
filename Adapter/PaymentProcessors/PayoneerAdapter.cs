using Adapter.Entities;
using System;

namespace Adapter.PaymentProcessors
{
    class PayoneerAdapter : IPaypalPayment
    {
        public Payoneer Payoneer { get; set; }

        public PayoneerAdapter(Payoneer payoneer)
        {
            Payoneer = payoneer;
        }

        public Token AuthToken()
        {
            return Payoneer.AuthToken();
        }

        public void PayPalPayment()
        {
            Payoneer.SendPayment();
        }

        public void PayPalReceive()
        {
            Payoneer.ReceivePayment();
        }
    }
}
