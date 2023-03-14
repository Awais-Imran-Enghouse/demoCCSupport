
@browser
Feature: Feature1

A short summary of the feature

@tag1
Scenario: Login to VCC application
	Given I am at VCC login page.
	When I enter credentials.
	Then I get logged in.


Scenario: Adding user in CCSupport.
	Given I am at VCC login page.
	When I enter credentials.
	Then I get logged in.
	When I click on CCSupport.
	When I click on add user button.
	When I enter Username.
	And I enter Email Address.
	And I click on the profile tab.
	And I click the OK button.
	Then The agent is successfully created.
