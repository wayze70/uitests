using NUnit.Framework;
using UITests.Terminal.PageObjects;

namespace UITests.Terminal
{
    [TestFixture]
    public class LoadTests : TestBase
    {
        private const int Iterations = 500;

        [Test]
        public static void Load_Test()
        {
            for (int i = 1; i <= Iterations; i++)
            {
                // Go to people list
                PageFactory.HomePage.ClickToEnterPin();
                
                // Select person and enter pin
                PageFactory.SelectPersonPage.ClickToPerson();
                PageFactory.SelectPersonPage.EnterPin(1234);

                // Select activity
                PageFactory.TerminalPages.TerminalPage.ClickToActivity();

                // Wait for home page
                PageFactory.HomePage.WaitForPage();
            }
        }
    }
}
