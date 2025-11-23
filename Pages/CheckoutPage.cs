using OpenQA.Selenium;


namespace SauceDemoAutomation.Pages
{
    public class CheckoutPage
    {
        private readonly IWebDriver _driver;

        public CheckoutPage(IWebDriver driver) => _driver = driver;

        private IWebElement FirstName => _driver.FindElement(By.Id("first-name"));
        private IWebElement LastName => _driver.FindElement(By.Id("last-name"));
        private IWebElement PostalCode => _driver.FindElement(By.Id("postal-code"));
        private IWebElement ContinueButton => _driver.FindElement(By.Id("continue"));

        public void EnterCheckoutInfo(string firstName, string lastName, string postalCode)
        {
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
            PostalCode.SendKeys(postalCode);
            ContinueButton.Click();
        }
    }
}
