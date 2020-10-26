using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;
        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }
        [Test]
        [TestCase(2)]
        public void GenMagicNum_WithNegativeInputs_ResultThrownArgumentException(double a)
        {
            double result = _calculator.GenMagicNum(a, _mockFileReader);
            Assert.That(result, Is.EqualTo(691042));
        }
    }
}
