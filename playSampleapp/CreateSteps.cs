using System;
using TechTalk.SpecFlow;

namespace playSampleapp
{
    [Binding]
    public class CreateSteps
    {
        [Given(@"that I am on a home page of computer data base application")]
        public void GivenThatIAmOnAHomePageOfComputerDataBaseApplication()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Add a new computer button is displayed")]
        public void GivenAddANewComputerButtonIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the button")]
        public void WhenIClickOnTheButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be on the Add computer page")]
        public void ThenIShouldBeOnTheAddComputerPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"that I am on add computer page")]
        public void GivenThatIAmOnAddComputerPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"All the (.*) are displayed")]
        public void GivenAllTheAreDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I add data on the fields")]
        public void WhenIAddDataOnTheFields()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"click on create this computer button")]
        public void WhenClickOnCreateThisComputerButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"it should save the details")]
        public void ThenItShouldSaveTheDetails()
        {
            ScenarioContext.Current.Pending();
        }

    }

}


