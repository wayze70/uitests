namespace UITests.Terminal.PageObjects.SetupPages
{
    public class AccountPage
    {
        private FindBy _accountName = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.AccountPage.AccountNameTextBox);
        private FindBy _email = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.AccountPage.EmailTextBox);
        private FindBy _password = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.AccountPage.UserPasswordTextBox);
        private FindBy _continueButton = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.AccountPage.ContinueButton);

        public void WriteAllInformationOnPage(string accountName, string email, string password)
        {
            Session.SendKeys(_accountName.WaitForElementToBeClickable(), accountName);
            Session.SendKeys(_email.WaitForElementToBeClickable(), email);
            Session.SendKeys(_password.WaitForElementToBeClickable(), password);
        }

        public void ClickToContinueButton()
        {
            _continueButton.WaitForElementToBeClickable().Click();
        }
    }
}