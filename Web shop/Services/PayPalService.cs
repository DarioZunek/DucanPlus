using Microsoft.AspNetCore.Http.Features;
using PayPalCheckoutSdk.Orders;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Web_shop.Services
{
    public class PayPalService
    {
        private IConfiguration configuration;

        private PayPalCheckoutSdk.Core.SandboxEnvironment environment;
        private PayPalCheckoutSdk.Core.PayPalHttpClient client;

        public PayPalService(IConfiguration configuration)
        {
            this.configuration = configuration;
            var clientId = configuration.GetSection("PayPalSettings:ClientId").Value;
            var clientSecret = configuration.GetSection("PayPalSettings:ClientSecret").Value;
            environment = new PayPalCheckoutSdk.Core.SandboxEnvironment(clientId, clientSecret);
            this.client = new PayPalCheckoutSdk.Core.PayPalHttpClient(environment);
        }

        public async Task<string> CreateOrder(decimal amount)
        {
            string formattedAmount = amount.ToString(CultureInfo.InvariantCulture);
            var order = new OrderRequest()
            {
                CheckoutPaymentIntent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>
            {
                new PurchaseUnitRequest
                {
                    AmountWithBreakdown = new AmountWithBreakdown
                    {
                        CurrencyCode = "EUR",
                        Value = formattedAmount.ToString(),
                    }
                }
            },
                ApplicationContext = new ApplicationContext
                {
                    ReturnUrl = "localhost:7254/ShoppingCart",
                    CancelUrl = "localhost:7254/ShoppingCart"
                }
            };

            var request = new OrdersCreateRequest().RequestBody(order);
            var response = await client.Execute(request);
            var result = response.Result<Order>();
            var approvalUrl = result.Links.FirstOrDefault(link => link.Rel.Equals("approve")).Href;

            return approvalUrl;
        }
    }
}
