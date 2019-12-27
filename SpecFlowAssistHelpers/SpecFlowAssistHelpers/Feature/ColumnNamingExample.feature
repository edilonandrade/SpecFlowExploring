Feature: ColumnNamingExample

Scenario: Column Naming Example
	Given I entered the following data into the new account to column:
		| FirstName | LastName | Birthdate | HeightInInches |
		| John      | Galt     | 2/2/1902  | 72             |

Scenario: Column Naming Example diferrent table
	Given I entered the following data into the new account to column:
		| First name | Last name | Birth date | HEIGHT In Inches |
		| Peter      | Pan       | 2/2/1896   | 80               |