Feature: Payment smoke tests
	In order to test the payment fast

Scenario Outline: Make a payment
	Given user is logged
	Given I add a new book (<Author>,<Title>,<Description>, <Id>)
	When I request to deleate a books with id (<TestId>)
	Then system should delete the book

Examples: 
	| Author      | Title      | Description      | Id | TestId |
	| TestAuthor1 | TestTitle1 | TestDescription1 | 7  |   7    |

	Scenario Outline: Delete a book - Negative
	Given I add a new book (<Author>,<Title>,<Description>, <Id>)
	When I request to deleate a books with id (<TestId>)
	Then system should delete the book

Examples: 
	| Author      | Title      | Description      | Id | TestId |
	| TestAuthor0 | TestTitle0 | TestDescription0 | 1  |        |
	| TestAuthor2 | TestTitle2 | TestDescription2 | 2  |   30   |