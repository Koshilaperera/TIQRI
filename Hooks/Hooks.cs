using SauceDemoAutomation;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace SauceDemoAutomation.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void Setup()
        {
            // Configure Chrome for CI / headless
            var options = new ChromeOptions();
            options.AddArgument("--headless");                 // Run in headless mode
            options.AddArgument("--window-size=1920,1080");    // Ensure elements are visible
            options.AddArgument("--disable-gpu");             // Optional: disable GPU for CI
            options.AddArgument("--no-sandbox");

            Drivers.WebDriverFactory.Driver = new ChromeDriver(options);
            Drivers.WebDriverFactory.Driver.Manage().Window.Maximize();
            // Implicit wait for 10 seconds
            Drivers.WebDriverFactory.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void TearDown()
        {
            Drivers.WebDriverFactory.CloseDriver();
        }
    }
}