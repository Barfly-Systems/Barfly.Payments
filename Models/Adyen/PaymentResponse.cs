using Adyen.Model.Checkout;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barfly.Payments.Models.Adyen
{
    public class PaymentResponse
    {
        public int organisationId { get; set; }
        public PaymentsResponse paymentResponse { get; set; }
        public int? orderId { get; set; }
    }
}
