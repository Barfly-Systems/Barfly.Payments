﻿using System;
using System.Collections.Generic;
using System.Text;

using Adyen;
using Adyen.Model.Checkout;
using Adyen.Service;
using Barfly.Payments.Models.Adyen;
using mod = Adyen.Model;
using models = Barfly.Payments.Models.Adyen;

namespace Barfly.Payments.Adyen
{
    public class AdyenPayment
    {
        public string getPaymentMethods(int paymentValue)
        {
            var client = new Client("AQE7hmfuXNWTK0Qc+iSRlmU1lPCJSYJDPpxMTHJX1H2Ym3Rdl8RzA+p1AmA4WftafpYUaU5ZdfdhAJd3XEEQwV1bDb7kfNy1WIxIIkxgBw==-vWBMpptmnKKvlSHqmG+ne84CFkkG8tB+FwFLO2puXeU=-+Z6f4p>A{QB;4U9+", mod.Enum.Environment.Test);
            var checkout = new Checkout(client);
            var amount = new mod.Checkout.Amount("GBP", paymentValue);
            var paymentMethodsRequest = new mod.Checkout.PaymentMethodsRequest(merchantAccount: "AdamStrainSoftwareServicesLtd797ECOM")
            {
                CountryCode = "GB",
                ShopperLocale = "en_US",
                Amount = amount,
                Channel = PaymentMethodsRequest.ChannelEnum.Web
            };

            var paymentMethodsResponse = checkout.PaymentMethods(paymentMethodsRequest).ToJson();
            return paymentMethodsResponse;
        }

        public PaymentsResponse makePayment(mod.Checkout.DefaultPaymentMethodDetails req, int value, string reference)
        {
            try
            {
                var client = new Client("AQE7hmfuXNWTK0Qc+iSRlmU1lPCJSYJDPpxMTHJX1H2Ym3Rdl8RzA+p1AmA4WftafpYUaU5ZdfdhAJd3XEEQwV1bDb7kfNy1WIxIIkxgBw==-vWBMpptmnKKvlSHqmG+ne84CFkkG8tB+FwFLO2puXeU=-+Z6f4p>A{QB;4U9+", mod.Enum.Environment.Test);
                var checkout = new Checkout(client);
                var amount = new mod.Checkout.Amount("GBP", value);
                var details = req;
                var paymentRequest = new mod.Checkout.PaymentRequest
                {
                    Reference = reference,
                    Amount = amount,
                    ReturnUrl = @"https://example.com/checkout?shopperOrder",
                    MerchantAccount = "AdamStrainSoftwareServicesLtd797ECOM",
                    PaymentMethod = req
                };

                var paymentResponse = checkout.Payments(paymentRequest);
                return paymentResponse;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
