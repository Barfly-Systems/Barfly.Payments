using Adyen.Model.Checkout;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barfly.Payments.Models.Adyen
{
    public class paymentMethod: IPaymentMethodDetails
    {
        public string Type { get; set; }
        public string EncryptedCardNumber { get; set; }
        public string EncryptedExpiryMonth { get; set; }
        public string EncryptedExpiryYear { get; set; }
        public string EncryptedSecurityCode { get; set; }
    }
}
