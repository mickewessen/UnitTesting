using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.MSTest.Tests
{
    [TestClass]
    public class CalculatorTests
    {

        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(2, 2, 4)]

        public void Add_ShouldAddToValues(int value1, int value2, int expected)
        {
            var calc = new Calculator();
            Assert.AreEqual(expected, calc.Add(value1, value2));
        }




        //        [TestMethod]
        //        public void Create_ShouldCreateAPerson()
        //        {
        //            var person = new Person();
        //            bool actual = person.Create();
        //            Assert.IsTrue(actual);
        //        }
    }
}
