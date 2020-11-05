using Adyen.Model.Checkout;
using System;
using System.Collections.Generic;
using System.Text;

using mod = Adyen.Model;

namespace Barfly.Payments.Models.Adyen
{
    public class AdyenPaymentRequest
    {
        public int organisationId { get; set; }
        public int value { get; set; }
        public mod.Checkout.DefaultPaymentMethodDetails paymentMethod {get;set;}
    }
}
