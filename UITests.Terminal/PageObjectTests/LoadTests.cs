using NUnit.Framework;
using UITests.Terminal.PageObjects;

namespace UITests.Terminal
{
    [TestFixture]
    public class LoadTests : TestBase
    {
        private const int Iterations = 500;

        [Test]
        public static void LoadTest()
        {
            for (int i = 1; i <= Iterations; i++)
            {
                // Go to people list
                PageFactory.HomePage.ClickToEnterPin();
                
                // Select first person and enter pin
                PageFactory.SelectPersonPage.ClickToPerson();
                PageFactory.SelectPersonPage.EnterPin(1234);

                // Select activity
                PageFactory.TerminalTerminalPage.ClickToActivity();

                // Wait for home page
                PageFactory.HomePage.WaitForPage();
            }
        }
    }
}

