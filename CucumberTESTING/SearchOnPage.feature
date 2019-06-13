Feature: SearchOnPage
	

@Positive
Scenario: Searching the books
Given User open TaniaKsiazka page
When User type searched phrase
And User click enter
Then Searched phrase is displayed

When User chose Fantastyka from categories
And User click on Book
And User adds book to the basket
Then Book added to the basket

