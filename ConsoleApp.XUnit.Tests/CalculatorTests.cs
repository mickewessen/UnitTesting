using System;
using Xunit;

namespace ConsoleApp.XUnit.Tests
{

    // TDD - Test Driven Development (Test First Then Code)
    // Enhetstest (Unit Test), Integrationstest (Integration Test), Början till slut test (End To End Test)
    // RED, GREEN, REFACT

    public class CalculatorTests
    {

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]

        public void Add_ShouldAddToValues(int value1, int value2, int expected)
        {
            var calc = new Calculator();
            int actual = calc.Add(value1, value2);
            Assert.Equal(expected, actual);
        }



    }
}
