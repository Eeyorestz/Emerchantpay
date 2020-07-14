using Newtonsoft.Json;

namespace EmerchantpayPaymentSpecFlow.Model.Entities
{
   public class PaymentTransaction
    {
        [JsonProperty("card_number")]
        public string CardNumber { get; set; }

        [JsonProperty("cvv")]
        public string Cvv { get; set; }

        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("transaction_type")]
        public string TransactionType { get; set; }

        [JsonProperty("card_holder")]
        public string CardHolder { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
