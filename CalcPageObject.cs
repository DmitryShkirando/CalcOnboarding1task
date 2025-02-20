using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;

namespace CalcV2
{
    public class CalcPageObject
    {
        private readonly WindowsDriver<WindowsElement> driver;

        public CalcPageObject(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        private static readonly By num7Button = By.XPath("//*[@AutomationId='num7Button']");
        private static readonly By num5Button = By.XPath("//*[@AutomationId='num5Button']");
        private static readonly By plusButton = By.XPath("//*[@AutomationId='plusButton']");
        private static readonly By equalButton = By.XPath("//*[@AutomationId='equalButton']");
        private static readonly By calculatorResults = By.XPath("//*[@AutomationId='CalculatorResults']");
        private static readonly By multiplyButton = By.XPath("//*[@AutomationId='multiplyButton']");


        public void ClickNumber7() => driver.FindElement(num7Button).Click();
        public void ClickNumber5() => driver.FindElement(num5Button).Click();
        public void ClickPlus() => driver.FindElement(plusButton).Click();
        public void ClickEqual() => driver.FindElement(equalButton).Click();

        public string GetResult()
        {
            var result = driver.FindElement(calculatorResults).Text;
            // Берем последнее слово (оно должно быть числом)
            return result.Split(' ').Last().Trim();
        }

        public void ClickNumber(int number)
        {
            string automationId = $"num{number}Button";
            driver.FindElement(By.XPath($"//*[@AutomationId='{automationId}']")).Click();
        }

        public void ClickMultiply() => driver.FindElement(multiplyButton).Click();

    }
}
