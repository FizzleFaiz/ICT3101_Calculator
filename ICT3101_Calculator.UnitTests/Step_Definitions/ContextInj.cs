using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class ContextInj
    {
        private Calculator _calculator;
        public ContextInj(Calculator calculator)
        {
            this._calculator = calculator;
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
    }
}
