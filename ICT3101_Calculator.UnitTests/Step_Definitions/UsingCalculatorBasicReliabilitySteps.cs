using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private Calculator _calculator;
        public UsingCalculatorBasicReliabilitySteps(Calculator calculator)
        {
            this._calculator = calculator;
        }
        private double _result;
        private double _assume;
        [Given(@"assume program will experience (.*) failures in infinite time")]
        public void GivenAssumeProgramWillExperienceFailuresInInfiniteTime(int p0)
        {
            _assume = p0;
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press CFI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCFI(int p0, int p1)
        {
            _result = _calculator.CFI(p0, p1,_assume);
        }
        
        [Then(@"the current failure intensity rate result should be ""(.*)""")]
        public void ThenTheCurrentFailureIntensityRateResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press AEF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAEF(int p0, int p1)
        {
            _result = _calculator.AEF(p0, p1, _assume);
        }

        [Then(@"the average number of expected failures result should be ""(.*)""")]
        public void ThenTheAverageNumberOfExpectedFailuresResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
