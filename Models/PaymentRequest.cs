using System;
using System.Collections.Generic;
using System.Text;

namespace Barfly.Payments.Models
{
    public class PaymentRequest
    {
        public string orderToken { get; set; }
        public int? orderValue { get; set; }
        public string name { get; set; }
        public string orderDescription { get; set; }
        public string customerOrderCode { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
    }
}
