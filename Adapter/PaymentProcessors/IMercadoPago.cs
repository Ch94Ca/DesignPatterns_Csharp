using Adapter.Entities;

namespace Adapter.PaymentProcessors
{
    interface IMercadoPago
    {
        Token AuthToken();
        void SendMP();
        void ReceiveMP();
    }
}
