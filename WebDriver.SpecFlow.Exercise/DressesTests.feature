Feature: DressesTests

I want to be able to add dresses to the cart, to quickly view dresses details and to set the desired size,
color and quantity

Background:
    Given Start Web browser

@testingFramework
Scenario: Add dresses for comparison
	When I navigate to the Shopping site
	And I add dresses for comparison
	And I open the comparison page
	Then assert that the two dresses are added for comparison
	Then verify the information displayed on the comparison screen
	Then Close Web browser 

Scenario: Navigate to Quick view and verify the info
	When I navigate to the Shopping site
	And I open a dress's Quick View
	Then assert the displayed information
	Then Close Web browser

Scenario: Modify dress details and add it to cart from Quick view
	When I navigate to the Shopping site
	And I open a dress's Quick View
	And I set the wanted details <size> <color> <quantity>
	And I add it to the cart
	Then assert that the dress is added to the cart
	Then Close Web browser
Examples:
| size | color | quantity |
| S    | Pink  | 2        |
| L    | Beige | 3        |
| M    | Pink  | 2        |



