Feature: AddANZBankAccount
	As a Xero User,
	In order to manage my business successfully,
	I want to be able to add an “ANZ (NZ)” bank account inside any Xero Organisation.

Background:
	Given I am in the login page
	When I enter "peralta.keit@gmail.com" into the email address field
	And I enter "Test1234!" into the password field
	And I click the login button
	And I click the Use backup method instead link
	And I click Security questions
	And I answer the security questions
	And I click the confirm button
	Then I should be taken to my dashboard page

@mytag
Scenario: Successfully add an ANZ Bank account
	Given I click the Accounting navigation button
	When I click the Bank accounts option
	Then I should be taken to the bank accounts page
	And I click the Add Bank Account button
	When I click on the ANZ (NZ) option
	And I enter a unique bank account name
	And I select the first account type
	And I enter an account number into the account number field
	And I click the continue button
	##Then I should see my bank account in the list of bank accounts
	When I click the Ive got a form button
	And I click the Ill do it later button
	And I click the go to dashboard button
	Then I should see my unique bank account name in my dashboard