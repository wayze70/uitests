using NUnit.Framework;
using System.IO;
using UITests.Terminal.PageObjects;

namespace UITests.Terminal
{
    [TestFixture]
    public class TestBase
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Session.InitLocalDrivers();

            if (PageFactory.SetupPages.WelcomePage.IsStartTheSetupWizzardVisible())
            {
                PageFactory.SetupPages.WelcomePage.ClickToStartTheSetupWizzard();
                PageFactory.SetupPages.AccountPage.WriteAllInformationOnPage(Session.GetAcountName(Session.Enviroment), Constants.Account.Email, Constants.Account.Password);
                PageFactory.SetupPages.AccountPage.ClickToContinueButton();
                PageFactory.SetupPages.NameAndLocationPage.WriteAllInformationOnPage(Constants.Terminal.Name);
                PageFactory.SetupPages.NameAndLocationPage.ClickToContinueButton();
                PageFactory.SetupPages.PasswordPage.WriteAllInformationOnPage(Constants.Terminal.Password, Constants.Terminal.Password);
                PageFactory.SetupPages.PasswordPage.ClickToFinishButton();
            }

            PageFactory.HomePage.WaitForPage();

            if (PageFactory.HomePage.IsMessageTextBlockVisible())
            {
                PageFactory.HomePage.ClickToGoToSettings();
                PageFactory.SettingsPages.LoginToTerminalSettingsPage.WriteAllInformationOnPage(Constants.Terminal.Password);
                PageFactory.SettingsPages.LoginToTerminalSettingsPage.ClickToContinueButton();
                Assert.AreEqual(LocalizedStrings.SettingsPageTitles.People, PageFactory.SettingsPages.PeoplePage.GetPageTitle());
                PageFactory.SettingsPages.PeoplePage.SetPinToAllPeople(Constants.Terminal.Pin);
                PageFactory.SettingsPages.PeoplePage.ClickToBackButton();
                PageFactory.HomePage.WaitForPage();
                Assert.False(PageFactory.HomePage.IsMessageTextBlockVisible());
            }
        }

        [TearDown]
        public virtual void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Session.TakeScreenshot(Path.Combine(Constants.Directory.Errors, TestContext.CurrentContext.Test.MethodName));
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Session.Driver.Quit();
        }
    }
}
