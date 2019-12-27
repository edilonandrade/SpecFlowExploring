Feature: CompareToInstanceExample

Scenario: Compare Person Class
	Then the person should have the following values
		| Field     | Value |
		| FirstName | John  |
		| LastName  | Galt  |
		| YearsOld  | 54    |