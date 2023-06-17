using System;
using NUnit.Framework;

namespace SimpleApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            var result = _calculator.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsDifferenceOfArguments()
        {
            var result = _calculator.Subtract(5, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}