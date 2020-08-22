using System;

using Worldpay.Sdk;
using Worldpay.Sdk.Models;
using Worldpay.Sdk.Enums;

using Barfly.Payments.Models;
using System.Threading.Tasks;

namespace Barfly.Payments
{
    public class WorldpayPayment
    {
        public async Task<OrderResponse> doPayment(PaymentRequest paymentRequest)
        {
            try
            {
                WorldpayRestClient client = new WorldpayRestClient("https://api.worldpay.com/v1", "T_S_6bbff3eb-5b63-4a0f-9927-cc04bba97457");

            var orderRequest = new OrderRequest()
            {
                token = paymentRequest.orderToken,
                amount = paymentRequest.orderValue,
                currencyCode = CurrencyCode.GBP,
                name = paymentRequest.name,
                orderDescription = paymentRequest.orderDescription,
                customerOrderCode = paymentRequest.customerOrderCode
            };

            var address = new Address()
            {
                address1 = paymentRequest.address1,
                address2 = paymentRequest.address2,
                city = paymentRequest.city,
                countryCode = CountryCode.GB.ToString(),
                postalCode = paymentRequest.postalCode
            };

            orderRequest.billingAddress = address;

            
                OrderResponse orderResponse = await client.GetOrderService().Create(orderRequest);
                return orderResponse;

            }
            catch(WorldpayException ex)
            {
                throw ex;
            }

        }
    }
}
