using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionCalculator.Tests
{
    [TestClass]
    public class FunctionCalculatorTests
    {
        [TestMethod]
        public void TestValidCalculation()
        {
            // Arrange
            double N = 5.0;
            int k = 10;
            FunctionCalculator calculator = new FunctionCalculator();

            // Act
            double[] results = calculator.CalculateFunctionValues(N, k);

            // Assert
            Assert.AreEqual(k, results.Length);
            foreach (double result in results)
            {
                Assert.AreNotEqual(double.PositiveInfinity, result);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            // Arrange
            double N = 0.0;
            int k = 10;
            FunctionCalculator calculator = new FunctionCalculator();

            // Act
            double[] results = calculator.CalculateFunctionValues(N, k);

            // Assert
            // Should throw DivideByZeroException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestOutOfRange()
        {
            // Arrange
            double N = 10.0; // Make sure it's beyond the range of k
            int k = 10;
            FunctionCalculator calculator = new FunctionCalculator();

            // Act
            double[] results = calculator.CalculateFunctionValues(N, k);

            // Assert
            // Should throw ArgumentOutOfRangeException
        }
    }
}