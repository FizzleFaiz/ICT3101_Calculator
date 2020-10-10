Feature: UsingCalculatorBasicReliability
		In order to calculate the Basic Musa model's failures/intensities
		As a Software Quality Metric enthusiast
		I want to use my calculator to do this

@Musa
Scenario: Calculate Initial Failure Intensity
	Given I have a calculator
	And assume program will experience 100 failures in infinite time
	When I have entered "10" and "50" into the calculator and press CFI
	Then the current failure intensity rate result should be "5"

@Musa
Scenario: Calculate Average Number of Expected Failures after 10 hours
	Given I have a calculator
	And assume program will experience 100 failures in infinite time
	When I have entered "10" and "10" into the calculator and press AEF
	Then the average number of expected failures result should be "63"

@Musa
Scenario: Calculate Average Number of Expected Failures after 100 hours
	Given I have a calculator
	And assume program will experience 100 failures in infinite time
	When I have entered "10" and "100" into the calculator and press AEF
	Then the average number of expected failures result should be "100"
