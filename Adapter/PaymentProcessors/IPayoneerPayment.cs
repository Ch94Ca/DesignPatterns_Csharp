using Adapter.Entities;

namespace Adapter.PaymentProcessors
{
    interface IPayoneerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();

    }
}
