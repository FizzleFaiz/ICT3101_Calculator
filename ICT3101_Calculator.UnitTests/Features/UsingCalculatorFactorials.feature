Feature: UsingCalculatorFactorials
    In order to conquer factorials
    As a factorial enthusiast
    I want to understand a variety of factorial operations

@Factorial
Scenario: Factorial positive number
Given I have a calculator
When I have entered "5" and "2" into the calculator and press factorial
Then the factorial result should be "120"

@Factorial
Scenario: Factorial zero number
Given I have a calculator
When I have entered "0" and "2" into the calculator and press factorial
Then the factorial result should be "1"