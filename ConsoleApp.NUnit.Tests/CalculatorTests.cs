using NUnit.Framework;

namespace ConsoleApp.NUnit.Tests
{
    public class Tests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();

        }

        [Theory]
        [TestCase(1,1,2)]
        [TestCase(2, 2, 4)]
        public void Add_ShouldAddToValues(int value1, int value2, int expected)
        {
            Assert.AreEqual(expected, calc.Add(value1,value2));
        }
    }
}