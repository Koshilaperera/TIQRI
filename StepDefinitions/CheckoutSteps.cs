using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SauceDemoAutomation.Pages;

namespace SauceDemoAutomation.Steps
{
    [Binding]
    public class CheckoutSteps
    {
        // Lazy property; safe after BeforeScenario hook
        private IWebDriver _driver => Drivers.WebDriverFactory.Driver!;

        private LoginPage? loginPage;
        private ProductsPage? productsPage;
        private CartPage? cartPage;
        private CheckoutPage? checkoutPage;
        private CheckoutOverviewPage? checkoutOverviewPage;

        [Given(@"I am logged in with standard_user credentials")]
        public void GivenIAmLoggedIn()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            loginPage = new LoginPage(_driver);
            loginPage.Login("standard_user", "secret_sauce");

        }

        [When(@"I add a product to the cart")]
        public void WhenIAddProductToCart()
        {
            productsPage = new ProductsPage(_driver);
            productsPage.AddFirstProductToCart();
        }

        [When(@"I navigate to the cart")]
        public void WhenINavigateToCart() => productsPage!.GoToCart();

        [When(@"I proceed to checkout")]
        public void WhenIProceedToCheckout()
        {
            cartPage = new CartPage(_driver);
            cartPage.ProceedToCheckout();
        }

        [When(@"I enter valid checkout information")]
        public void WhenIEnterCheckoutInfo()
        {
            checkoutPage = new CheckoutPage(_driver);
            checkoutPage.EnterCheckoutInfo("John", "Doe", "12345");
        }

        [When(@"I finish the checkout")]
        public void WhenIFinishCheckout()
        {
            checkoutOverviewPage = new CheckoutOverviewPage(_driver);
            checkoutOverviewPage.FinishCheckout();
        }

        [Then(@"I should see the order confirmation")]
        public void ThenIShouldSeeConfirmation()
        {
            string confirmationText = checkoutOverviewPage!.GetConfirmationText();
            Assert.That(confirmationText, Is.EqualTo("Thank you for your order!"));
        }
    }
}