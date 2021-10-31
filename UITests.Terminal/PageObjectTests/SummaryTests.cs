using NUnit.Framework;
using UITests.Terminal.PageObjects;

namespace UITests.Terminal
{
    class SummaryTests : TestBase
    {
        [Test]
        public static void SummaryTest()
        {
            // Go to people list
            PageFactory.HomePage.ClickToEnterPin();

            // Select first person and enter pin
            PageFactory.SelectPersonPage.ClickToPerson();
            PageFactory.SelectPersonPage.EnterPin(1234);

            // Go to summary
            PageFactory.TerminalTerminalPage.ClickToSummaryMenuItem();
            PageFactory.TerminalSummaryPage.PageContentMustBeVisible();

            // Go back
            PageFactory.TerminalSummaryPage.ClickToLogoutMenuItem();
        }
    }
}
