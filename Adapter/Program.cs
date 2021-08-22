using System;
using Adapter.PaymentProcessors;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaypalPayment payment = new PayPal();

            payment.PayPalPayment();
            payment.PayPalReceive();

            payment = new PayoneerAdapter(new Payoneer());

            payment.PayPalPayment();
            payment.PayPalReceive();

            payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();
        }
    }
}
