using CalcV2.Steps;


namespace CalcV2.Testes
{
    internal class TestClass : Tests
    {
        private CalculatorSteps steps;

        [SetUp]
        public void Init()
        {
            steps = new CalculatorSteps(driver);
        }
       

        [Test]
        [TestCase(75, 75, 150)]
        [TestCase(7, 5, 12)]
        [TestCase(-3, 10, 7)]
        [TestCase(91, 1000, 1091)]
        public void SumTest(int a, int b, int expectedSum)
        {
            steps.SumOf(a, b, expectedSum);  
        }

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(10, 100, 1000)]
        [TestCase(-4, 5, -20)]
        [TestCase(0, 100, 0)]
        public void MultiplyTest(int a, int b, int expectedMulti)
        {
            steps.MultiplyNumbers(a, b, expectedMulti);
        }

        [Test]
        [TestCase(2, 3, -1)]
        [TestCase(10, 100, -90)]
        [TestCase(-4, -5, -9)]
        [TestCase(1101, 100, 1001)]
        public void Subtraction(int a, int b, int expectedMulti)
        {
            steps.Subtraction(a, b, expectedMulti);
        }

        [Test]
        [TestCase(1, 2, 0.5)]
        [TestCase(10, 100, 0.1)]
        [TestCase(4, 5, 0.8)]
        [TestCase(1101, 100, 11.01)]
        public void DevideNumbers(int a, int b, decimal expectedValue)
        {
            steps.Devide(a, b, expectedValue);
        }

    }
}
