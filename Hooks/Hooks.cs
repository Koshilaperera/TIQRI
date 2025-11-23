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
            Drivers.WebDriverFactory.Driver = new ChromeDriver();
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