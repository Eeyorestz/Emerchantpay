using RestSharp;
using System.Configuration;


namespace EmerchantpayPaymentSpecFlow.Utils
{
    public static class RequestFactory
    {
        public static IRestRequest GenerateRequest(string resource, string json, Method method)
        {
            IRestRequest request = new RestRequest(resource, DataFormat.Json);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Origin", $"{ConfigurationManager.AppSettings["environmentUrl"]}");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36");
            request.AddHeader("Content-Length", $"{json.Length}");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            request.Resource = resource;
            request.Method = method;

            return request;
        }
    }
}
