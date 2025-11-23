using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SauceDemoAutomation.Pages
{
    public class CartPage
    {
        private readonly IWebDriver _driver;

        private WebDriverWait Wait(int seconds = 50)
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(seconds));
        }


        public CartPage(IWebDriver driver) => _driver = driver;

        private IWebElement CheckoutButton => Wait().Until(ExpectedConditions.ElementToBeClickable(By.Id("checkout")));

        public void ProceedToCheckout() => CheckoutButton.Click();
    }
}
