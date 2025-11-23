using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace SauceDemoAutomation.Pages
{
    public class CheckoutPage
    {
        private readonly IWebDriver _driver;

        private WebDriverWait Wait(int seconds = 50)
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(seconds));
        }

        public CheckoutPage(IWebDriver driver) => _driver = driver;

        private IWebElement FirstName => Wait().Until(ExpectedConditions.ElementIsVisible(By.Id("first-name")));
        private IWebElement LastName => Wait().Until(ExpectedConditions.ElementIsVisible(By.Id("last-name")));
        private IWebElement PostalCode => Wait().Until(ExpectedConditions.ElementIsVisible(By.Id("postal-code")));
        private IWebElement ContinueButton => Wait().Until(ExpectedConditions.ElementToBeClickable(By.Id("continue")));

        public void EnterCheckoutInfo(string firstName, string lastName, string postalCode)
        {
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
            PostalCode.SendKeys(postalCode);
            ContinueButton.Click();
        }
    }
}
