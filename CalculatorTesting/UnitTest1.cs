using NUnit.Framework;
using Calculator;

namespace CalculatorTesting
{
    public class Tests
    {

        [Test]
        public void TestAddition()
        {
            var calculator = new Calculator.Calculator();
            Assert.That(calculator.GetResult(-20, 20, "+"), Is.EqualTo(0));
        }

        [Test]
        public void TestSubstraction()
        {
            var calculator = new Calculator.Calculator();
            Assert.That(calculator.GetResult(20, 20, "-"), Is.EqualTo(0));
        }

        [Test]
        public void TestMultiplication()
        {
            var calculator = new Calculator.Calculator();
            Assert.That(calculator.GetResult(20, 10, "*"), Is.EqualTo(200));
        }

        [Test]
        public void TestDivision()
        {
            var calculator = new Calculator.Calculator();
            Assert.That(calculator.GetResult(40, 20, "/"), Is.EqualTo(2));
        }

        [Test]
        public void TestDivisionByZero()
        {
            var calculator = new Calculator.Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.GetResult(40, 0, "/"));
        }

        [Test]
        public void TestInvalidOperation()
        {
            var calculator = new Calculator.Calculator();
            Assert.Throws<ArgumentException>(() => calculator.GetResult(5, 5, "%"));
        }

        [Test]
        public void TestFloatingPointPrecision()
        {
            var calculator = new Calculator.Calculator();
            Assert.That(calculator.GetResult(0.1, 0.2, "+"), Is.EqualTo(0.3).Within(0.0001));
        }

        [Test]
        public void TestAdditionWithNegatives()
        {
            var calculator = new Calculator.Calculator();
            Assert.That(calculator.GetResult(-5, -5, "+"), Is.EqualTo(-10));
        }

        [Test]
        public void TestMultiplicationWithZero()
        {
            var calculator = new Calculator.Calculator();
            Assert.That(calculator.GetResult(0, 100, "*"), Is.EqualTo(0));
        }
        
    }
}