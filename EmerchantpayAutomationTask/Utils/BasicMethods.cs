using EmerchantpayPaymentSpecFlow.Model.Entities;
using RestSharp;
using System.Net;

namespace EmerchantpayPaymentSpecFlow.Helpers
{

    public class BasicMethods
    {
        private IRestResponse _restResponse;
        private HttpRequestWrapper _requestWrapper;

        public HttpStatusCode ExtractStatusCode => _restResponse.StatusCode;
        public BasicMethods()
        {
            _requestWrapper = new HttpRequestWrapper();
        }

        public void CreatePayment(PaymentTransaction payment)
        {
            _restResponse = _requestWrapper.Create("/payment_transactions", payment);
        }

        public void Login() 
        {
            _requestWrapper.Login();
        }
    }
}
