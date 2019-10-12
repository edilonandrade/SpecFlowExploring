Feature: Exemplo2AcessoContextoCenario
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Subtract two numbers
	Given I have 50 into the calculator
	And I have 70 into the calculator
	When I press subtract
	Then the result -20 on the screen