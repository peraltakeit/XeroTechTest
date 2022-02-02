Feature: Login

@mytag
Scenario: Successfully Login
	Given I am in the login page
	When I enter "peralta.keit@gmail.com" into the email address field
	And I enter "Test1234!" into the password field
	And I click the login button
	And I click the Use backup method instead link
	And I click Security questions
	And I answer the security questions
	And I click the confirm button
	Then I should be taken to my dashboard page