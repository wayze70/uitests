using NUnit.Framework;
using UITests.Terminal.PageObjects;

namespace UITests.Terminal
{
    class SummaryTests : TestBase
    {
        [Test]
        public static void Summary_Test()
        {
            // Go to people list
            PageFactory.HomePage.ClickToEnterPin();

            // Select first person and enter pin
            PageFactory.SelectPersonPage.ClickToPerson();
            PageFactory.SelectPersonPage.EnterPin(1234);

            // Go to summary
            PageFactory.TerminalPages.TerminalPage.ClickToSummaryMenuItem();
            PageFactory.TerminalPages.SummaryPage.WaitForPageContent();

            // Go to home page
            PageFactory.TerminalPages.SummaryPage.ClickToLogoutMenuItem();
            PageFactory.HomePage.WaitForPage();
        }
    }
}
