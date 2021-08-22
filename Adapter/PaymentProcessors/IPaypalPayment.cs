using Adapter.Entities;

namespace Adapter.PaymentProcessors
{
    interface IPaypalPayment
    {
        Token AuthToken();

        void PayPalPayment();
        void PayPalReceive();
    }
}
