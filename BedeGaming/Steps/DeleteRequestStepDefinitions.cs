using TechTalk.Specflow;

namespace EmerchantpayPaymentSpecFlow.Steps
{
    [Binding]
    public class DeleteRequestStepDefinitions : Helpers.BasicMethods
    {
        [Given(@"User is logged")]
        public void WhenIRequestToDeleateABooksWithId(string id)
        {
            Login();
        }
    }
}
