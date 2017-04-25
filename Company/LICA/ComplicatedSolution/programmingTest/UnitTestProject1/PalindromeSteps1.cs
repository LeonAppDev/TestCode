using System;
using TechTalk.SpecFlow;
using programmingTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTest
{
    [Binding]
    public class PalindromeSteps
    {

        private string testString { get; set; }
        private bool result { get; set; }

        private Palindrome pTest = new Palindrome();

        [Given(@"I have entered a string '(.*)'")]
        public void GivenIHaveEnteredAString(string testString)
        {
            this.testString = testString;
        }

        [When(@"I press isPalindrome")]
        public void WhenIPressIsPalindrome()
        {
            result = pTest.isPalindrome(this.testString);
        }
        
        [Then(@"the result (.*) should be on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(bool expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
