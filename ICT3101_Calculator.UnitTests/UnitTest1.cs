using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        private IFileReader _reader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _reader = new FileReader();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        //[Test]
        //public void Divide_WithNegativeInputs_ResultThrowArgumentException()
        //{
        //    Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        //}
        //[Test]
        //[TestCase(0, 0)]
        //[TestCase(0, 10)]
        //[TestCase(10, 0)]
        //public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        //{
        //    Assert.That(() => _calculator.Divide(a,b), Throws.ArgumentException);
        //}
        [Test]
        [TestCase(-1, 0)]
        [TestCase(-2, 0)]
        public void Factorial_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Factorial(a, b), Throws.ArgumentException);
        }
        [Test]
        public void Factorial_WhenUsingPositiveNumbers_ResultEqualToFactorial()
        {
            // Act
            double result = _calculator.Factorial(5, 20);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        // Do Test cases for triangle and circle
        [Test]
        public void Triangle_WithLengthAndHeight_ResultEqualToArea()
        {
            // Act
            double result = _calculator.Triangle(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(100));
        }
        [Test]
        [TestCase(-10, 20)]
        [TestCase(10, -20)]
        public void Triangle_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Triangle(a, b), Throws.ArgumentException);
        }
        [Test]
        [TestCase(0, 20)]
        [TestCase(10, 0)]
        public void Triangle_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Triangle(a, b), Throws.ArgumentException);
        }

        [Test]
        public void Circle_WithRadius_ResultEqualToArea()
        {
            // Act
            double result = _calculator.Circle(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(314));
        }
        [Test]
        [TestCase(-10, 20)]
        public void Circle_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Circle(a, b), Throws.ArgumentException);
        }
        [Test]
        [TestCase(0, 20)]
        public void Circle_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Circle(a, b), Throws.ArgumentException);
        }
        [Test]
        [TestCase(2)]
        public void GenMagicNum_WithNegativeInputs_ResultThrownArgumentException(double a)
        {
            double result = _calculator.GenMagicNum(a, _reader);
            Assert.That(result, Is.EqualTo(691042));
        }
    }
}