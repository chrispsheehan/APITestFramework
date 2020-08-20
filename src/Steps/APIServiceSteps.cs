using TechTalk.SpecFlow;
using Drivers;
using System;

namespace StepDefinitions
{
    [Binding]
    public class APIServiceSteps
    {
        private readonly Driver _driver;

        public APIServiceSteps(Driver driver)
        {
            _driver = driver;
        }

        [Given(@"The profanity removing API is available")]
        public void GivenTheProfanityRemovingAPIIsAvailable()
        {

        }

        [Given(@"I am using the contains profanity service")]
        public void GivenIAmUsingTheContainsProfanityService()
        {

        }

        [Given(@"I am using the profanity character replacement service")]
        public void GivenIAmUsingTheProfanityCharacterReplacementService()
        {

        }

        [Given(@"I am using the profanity string replacement service")]
        public void GivenIAmUsingTheProfanityStringReplacementService()
        {

        }

        [When(@"I process the content")]
        public void WhenIProcessTheContent()
        {

        }

        [When(@"I receive an incomming text of (.*)")]
        public void WhenIReceiveAnIncommingTextOf(string text)
        {
            Console.WriteLine(text);
        }
    }
}
