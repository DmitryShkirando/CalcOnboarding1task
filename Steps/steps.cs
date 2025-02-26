using CalcV2.PageObject;
using OpenQA.Selenium.Appium.Windows;

namespace CalcV2.Steps
{
    public class CalculatorSteps
    {
        private readonly CalcPageObject calcPage;

        public CalculatorSteps(WindowsDriver<WindowsElement> driver)
        {
            calcPage = new CalcPageObject(driver);
        }

        public void SumOf(int num1, int num2, int expectedSum)
        {
            calcPage.ClickNumber(num1);
            calcPage.ClickPlus();
            calcPage.ClickNumber(num2);
            calcPage.ClickEqual();
            var result = calcPage.GetResult();

            Assert.AreEqual(expectedSum.ToString(), result, $"Expected {expectedSum}, but got {result}");
        }

        public void MultiplyNumbers(int num1, int num2, int expectedMulti)
        {
            calcPage.ClickNumber(num1);
            calcPage.ClickMultiply();
            calcPage.ClickNumber(num2);
            calcPage.ClickEqual();
            var result = calcPage.GetResult();

            Assert.AreEqual(expectedMulti.ToString(), result, $"Expected {expectedMulti}, but got {result}");
        }

        public void Subtraction(int num1, int num2, int expectedValue)
        {
            calcPage.ClickNumber(num1);
            calcPage.ClickMinus();
            calcPage.ClickNumber(num2);
            calcPage.ClickEqual();
            var result = calcPage.GetResult();

            Assert.AreEqual(expectedValue.ToString(), result, $"Expected {expectedValue}, but got {result}");
        }

        public void Devide(int num1, int num2, decimal expectedValue)
        {
            calcPage.ClickNumber(num1);
            calcPage.ClickDivide();
            calcPage.ClickNumber(num2);
            calcPage.ClickEqual();
            var result = calcPage.GetResult();

            Assert.AreEqual(expectedValue.ToString(), result, $"Expected {expectedValue}, but got {result}");
        }
    }
}
