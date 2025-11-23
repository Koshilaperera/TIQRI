using OpenQA.Selenium;

namespace SauceDemoAutomation.Pages
{
    public class ProductsPage
    {
        private readonly IWebDriver _driver;

        public ProductsPage(IWebDriver driver) => _driver = driver;

        private IWebElement AddToCartButton => _driver.FindElement(By.CssSelector(".btn_inventory"));
        private IWebElement CartIcon => _driver.FindElement(By.ClassName("shopping_cart_link"));

        public void AddFirstProductToCart() => AddToCartButton.Click();
        public void GoToCart() => CartIcon.Click();
    }
}
