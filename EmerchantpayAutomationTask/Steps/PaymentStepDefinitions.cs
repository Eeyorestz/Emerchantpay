
using TechTalk.SpecFlow;

namespace EmerchantpayPaymentSpecFlow.Steps
{
    [Binding]
    class PaymentStepDefinitions : Helpers.BasicMethods
    {
        [When(@"user is logged")]
        public void WhenUserIsLogged()
        {
            Login();
        }
    }
}
