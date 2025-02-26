using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;

namespace CalcV2.PageObject
{
    public class CalcPageObject
    {
        private readonly WindowsDriver<WindowsElement> driver;

        public CalcPageObject(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        private readonly By equalButton = By.XPath("//*[@AutomationId='equalButton']");
        private readonly By plusButton = By.XPath("//*[@AutomationId='plusButton']");
        private readonly By minusButton = By.XPath("//*[@AutomationId='minusButton']");
        private readonly By devideButton = By.XPath("//*[@AutomationId='divideButton']");
        private readonly By multiplyButton = By.XPath("//*[@AutomationId='multiplyButton']");
        private readonly By calculatorResults = By.XPath("//*[@AutomationId='CalculatorResults']");

        
        public void ClickNumber(int number)
        {
            string numberStr = number.ToString();

            if (numberStr.StartsWith("-")) 
            {
                ClickMinus(); 
                numberStr = numberStr.Substring(1); 
            }

            foreach (char digit in numberStr) 
            {
                By numberButton = By.XPath($"//*[@AutomationId='num{digit}Button']");
                driver.FindElement(numberButton).Click();
            }
        }
        public void ClickPlus() => driver.FindElement(plusButton).Click();
        public void ClickEqual() => driver.FindElement(equalButton).Click();
        public void ClickMinus() => driver.FindElement(minusButton).Click();
        public void ClickDivide() => driver.FindElement(devideButton).Click();
        public void ClickMultiply() => driver.FindElement(multiplyButton).Click();


        public string GetResult()
        {
            var result = driver.FindElement(calculatorResults).Text;
            return result.Split(' ').Last().Replace(",", "").Trim(); 
        }


    }
}


