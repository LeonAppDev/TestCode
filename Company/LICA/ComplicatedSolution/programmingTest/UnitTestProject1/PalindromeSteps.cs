using System;
using TechTalk.SpecFlow;

namespace SpecflowTest
{
    [Binding]
    public class PalindromeSteps
    {
        [Given(@"I have entered a string aaa")]
        public void GivenIHaveEnteredAStringAaa()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press isPalindrome")]
        public void WhenIPressIsPalindrome()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result (.*) should be on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
