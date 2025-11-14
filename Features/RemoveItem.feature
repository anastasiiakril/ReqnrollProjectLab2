Feature: Remove item from cart or inventory


@tag1
Scenario: Remove item from inventory page
	Given user is logged in as "problem_user" with password "secret_sauce"
	When user adds an item 
	And user removes the item from the inventory
	Then the item should be removed from the inventory

@tag1
Scenario: Remove item from cart page
	Given user is logged in as "problem_user" with password "secret_sauce"
	When user adds an item 
	And navigates to the cart page
	And user removes the item from the cart
	Then the item should be removed from the cart

