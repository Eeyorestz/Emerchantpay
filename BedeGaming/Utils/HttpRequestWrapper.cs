using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;
using System.Collections.Generic;
using EmerchantpayPaymentSpecFlow.Utils;
using RestSharp.Authenticators;

namespace EmerchantpayPaymentSpecFlow.Helpers
{
    public class HttpRequestWrapper
    {
        private RestClient _restClient;

        public HttpRequestWrapper()
        {
            _restClient = new RestClient(ConfigurationManager.AppSettings["environmentUrl"]);
        }

        public IRestResponse<TItem> Create<TItem>(string path, TItem payment)
        {
            string json = JsonConvert.SerializeObject(payment);
            IRestRequest request = RequestFactory.GenerateRequest(path, json, Method.POST);
  
           return  _restClient.Execute<TItem>(request);
        }

        public void Login()
        {
            var userName = ConfigurationManager.AppSettings["userName"];
            var password = ConfigurationManager.AppSettings["password"];
            _restClient.Authenticator = new HttpBasicAuthenticator(userName, password);
           
            var request = new RestRequest("resource", Method.GET);
            _restClient.Execute(request);
        }
    }
}
