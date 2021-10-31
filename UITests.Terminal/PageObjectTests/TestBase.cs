using NUnit.Framework;
using System.IO;
using UITests.Terminal.PageObjects;

namespace UITests.Terminal
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public void Login()
        {
            if (PageFactory.LoginWelcomePage.IsStartTheSetupWizzardDisplayed())
            {
                PageFactory.LoginWelcomePage.ClickToStartTheSetupWizzard();

                switch (Session.Enviroment)
                {
                    case Constants.Enviroment.Production:
                        PageFactory.LoginAccountPage.WriteAllInformationOnPage(Constants.Account.Production.AccountName, Constants.Account.Production.Email, Constants.Account.Production.Password);
                        break;

                    case Constants.Enviroment.Staging:
                        PageFactory.LoginAccountPage.WriteAllInformationOnPage(Constants.Account.Staging.AccountName, Constants.Account.Staging.Email, Constants.Account.Staging.Password);
                        break;

                    case Constants.Enviroment.Development:
                        PageFactory.LoginAccountPage.WriteAllInformationOnPage(Constants.Account.Development.AccountName, Constants.Account.Development.Email, Constants.Account.Development.Password);
                        break;
                }

                PageFactory.LoginAccountPage.ClickToContinueButton();
                PageFactory.LoginNameAndLocationPage.WriteAllInformationOnPage("HW-Terminal");
                PageFactory.LoginNameAndLocationPage.ClickToContinueButton();
                PageFactory.LoginPasswordPage.WriteAllInformationOnPage("123456", "123456");
                PageFactory.LoginPasswordPage.ClickToFinishButton();
            }

            PageFactory.HomePage.WaitForPage();
        }

        [TearDown]
        public virtual void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Session.TakeScreenshot(Path.Combine(Constants.Directory.Errors, TestContext.CurrentContext.Test.MethodName));
            }
        }
    }
}