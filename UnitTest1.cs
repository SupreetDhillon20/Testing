using BasicMath1;
namespace BasicMathTest
{
    public class Tests
    {
        private BasicMath basicMath;
        [SetUp]
        public void Setup()
        {
            basicMath = new BasicMath();
        }

        [TestCase(10.1,5.1,15.2)]
        [TestCase(14, 7, 21)]
        public void AddTest(double num1, double num2, double expectedResult)
        {
            double result = basicMath.Add(num1, num2);  
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(10.2, 5.1, 5.1)]
        [TestCase(14, 7, 7)]
        public void SubtractTest(double num1, double num2, double expectedResult)
        {
            double result = basicMath.Subtract(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(10.1, 5.1, 51.51)]
        [TestCase(14, 7, 98)]
        public void MultiplyTest(double num1, double num2, double expectedResult)
        {
            double result = basicMath.Multiply(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(10.2, 5.1, 2)]
        [TestCase(14, 7, 2)]
        public void DivideTest(double num1, double num2, double expectedResult)
        {
            double result = basicMath.Divide(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}