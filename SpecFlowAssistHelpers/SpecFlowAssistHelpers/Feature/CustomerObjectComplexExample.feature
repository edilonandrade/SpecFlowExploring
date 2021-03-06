﻿#https://github.com/kevinkuszyk/specflow-table-to-complex-type-sample

Feature: CustomerObjectComplexExample

Scenario: Add a customer
	Given I have the following customers
		| FirstName | LastName | Address.Address1 | Address.Address2 | Address.Town | Address.PostCode |
		| Kevin     | Kuszyk   | Address 1        | Address 2        | Town         | LS1 1AB          |
		| John      | Smith    | A house          | Somewhere        | Else         | EL1 1SE          |