using NUnit.Framework;

namespace UITests.Terminal.PageObjects.Settings
{
    public class YourAccount : SettingsSideMenu
    {
        private CustomFindBy _accountName = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.YourAccountPage.AccountTextBox);
        private CustomFindBy _email = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.YourAccountPage.EmailTextBox);
        private CustomFindBy _password = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.YourAccountPage.UserPasswordTextBox);
        private CustomFindBy _continueButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.YourAccountPage.ContinueButton);

        public void CheckInforationOnThisPage()
        {
            // TO DO GET LOGIN INFO
            Assert.AreEqual(_accountName.GetElement().Text, "stagedbsyristeautoterminal");
            Assert.AreEqual(_email.GetElement().Text, "michal.syriste@vykazprace.cz");
            // Assert.IsEmpty(_password.GetElement().Text);
        }

        public void WritePassword(int password)
        {
            Session.SendKeys(_password.WaitForElementToBeClickable(), password.ToString());
        }

        public void ClickToContinueButton()
        {
            _continueButton.WaitForElementToBeClickable().Click();
        }
    }
}
