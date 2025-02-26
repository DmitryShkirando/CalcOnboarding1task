using CalcV2.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;


namespace CalcV2.Testes
{
    public class Tests
    {
        protected WindowsDriver<WindowsElement> driver;
        protected CalcPageObject calcPage;

        [SetUp]
        public void Setup()
        {
            var options = new AppiumOptions();
            options.PlatformName = "Windows";
            options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");

            driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
            calcPage = new CalcPageObject(driver);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}