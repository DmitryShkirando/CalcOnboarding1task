
namespace CalcV2
{
    internal class TestClass : Tests
    {
        [Test]
        public void SumTest()
        {
            calcPage.ClickNumber7();
            calcPage.ClickPlus();
            calcPage.ClickNumber5();
            calcPage.ClickEqual();

            var result = calcPage.GetResult();

            Assert.AreEqual("12", result, "Result is not valid");
        }

        [Test]
        [TestCase(7, 5, 12)]
        [TestCase(3, 8, 11)]
        [TestCase(9, 1, 10)]
        public void SumOf2AnyValues(int a, int b, int expectedSum)
        {
            calcPage.ClickNumber(a);
            calcPage.ClickPlus();
            calcPage.ClickNumber(b);
            calcPage.ClickEqual();

            var result = calcPage.GetResult();

            Assert.AreEqual(expectedSum.ToString(), result, $"Expected {expectedSum}, but got {result}");
        }

        [Test]
        [TestCase(7, 5, 35)]
        [TestCase(3, 8, 24)]
        [TestCase(9, 2, 18)]
        public void MultiplyTwoValues(int a, int b, int expectedProduct)
        {
            calcPage.ClickNumber(a);
            calcPage.ClickMultiply();
            calcPage.ClickNumber(b);
            calcPage.ClickEqual();

            var result = calcPage.GetResult();

            Assert.AreEqual(expectedProduct.ToString(), result, $"Expected {expectedProduct}, but got {result}");
        }
    }
}
