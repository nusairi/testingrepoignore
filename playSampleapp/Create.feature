Feature: Create
	In order to add a new computer to the Play sample application 
	I would like to have a link on a home page so that I can navigate to the "Add a new computer page" and I should be able to add a new computer to the application. 

@mytag
Scenario: Navigate to "Add a computer page"

Given that I am on a home page of computer data base application 
And Add a new computer button is displayed 
When I click on the button 
Then I should be on the Add computer page 
	

Scenario Outline: Add computer page fields 
Given that I am on add computer page
Then All the <Fields> should be displayed
Examples: 
| Fields            |
| Computer name     |
| Introduced date   |
| Discontinued date |

Scenario: Add computer page company dropdown
Given that I am on add computer page
When I click on the dropdown menu
Then it should display list of companies
When I choose 'RCA'
Then it should select 'RCA'





