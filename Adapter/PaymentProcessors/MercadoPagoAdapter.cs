using Adapter.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.PaymentProcessors
{
    class MercadoPagoAdapter : IPaypalPayment
    {
        public MercadoPago MercadoPago { get; set; }

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            MercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return MercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            MercadoPago.SendMP();
        }

        public void PayPalReceive()
        {
            MercadoPago.ReceiveMP();
        }
    }
}
