using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialsSteps
    {
        private Calculator _calculator;
        public UsingCalculatorFactorialsSteps(Calculator calculator)
        {
            this._calculator = calculator;
        }
        private double _result;
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFactorial(int p0, int p1)
        {
            _result = _calculator.Factorial(p0, p1);
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
