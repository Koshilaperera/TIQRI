using OpenQA.Selenium;

namespace SauceDemoAutomation.Pages
{
    public class CheckoutOverviewPage
    {
        private readonly IWebDriver _driver;

        public CheckoutOverviewPage(IWebDriver driver) => _driver = driver;

        private IWebElement FinishButton => _driver.FindElement(By.Id("finish"));
        private IWebElement ConfirmationMessage => _driver.FindElement(By.ClassName("complete-header"));

        public void FinishCheckout() => FinishButton.Click();
        public string GetConfirmationText() => ConfirmationMessage.Text;
    }
}
