using NUnit.Framework;

namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class YourAccount : SettingsSideMenu
    {
        private FindBy _accountName = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.YourAccountPage.AccountTextBox);
        private FindBy _email = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.YourAccountPage.EmailTextBox);
        private FindBy _password = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.YourAccountPage.UserPasswordTextBox);
        private FindBy _continueButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.YourAccountPage.ContinueButton);

        public void CheckInforationOnThisPage()
        {
            Assert.AreEqual(_accountName.WaitForElementIfVisible().Text, Session.GetAcountName(Session.Enviroment));
            Assert.AreEqual(_email.WaitForElementIfVisible().Text, Constants.Account.Email);
            Assert.IsEmpty(_password.WaitForElementIfVisible().Text);
        }

        public void WritePassword(string password)
        {
            Session.SendKeys(_password.WaitForElementToBeClickable(), password);
        }

        public void ClickToContinueButton()
        {
            _continueButton.WaitForElementToBeClickable().Click();
        }
    }
}
