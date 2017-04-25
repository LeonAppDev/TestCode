Feature: Palindrome
	In order to avoid silly mistakes
	As a character idiot
	I want to be told a character or its anagram is palindrome or not

@mytag
Scenario: Verify a string or its anagram is palindrome 
	Given I have entered a string 'aaaa'
	When I press isPalindrome
	Then the result true should be on the screen
