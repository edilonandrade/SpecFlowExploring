Feature: CreateInstanceExample

Scenario: Add a book with table in vertical
	Given I entered the following data into the new account form in vertical:
		| Field              | Value     |
		| Name               | John Galt |
		| Birthdate          | 2/2/1902  |
		| HeightInInches     | 72        |
		| BankAccountBalance | 1234.56   |

Scenario: Add a book with table in horizontal
	Given I entered the following data into the new account form in horizontal:
		| Name      | Birthdate | HeightInInches | BankAccountBalance |
		| John Galt | 2/2/1902  | 72             | 1234.56            |