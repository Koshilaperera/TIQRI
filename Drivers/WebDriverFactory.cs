using OpenQA.Selenium;

namespace SauceDemoAutomation
{ 
    public static class Drivers
    {
        public static class WebDriverFactory
        {
            public static IWebDriver? Driver { get; set; }

            public static void CloseDriver()
            {
                Driver?.Quit();
                Driver = null;
            }
        }
    }

}

