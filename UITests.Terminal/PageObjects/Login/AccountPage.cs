namespace UITests.Terminal.PageObjects.Login
{
    public class AccountPage
    {
        private CustomFindBy _accountName = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.AccountPage.AccountNameTextBox);
        private CustomFindBy _email = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.AccountPage.EmailTextBox);
        private CustomFindBy _password = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.AccountPage.UserPassword);
        private CustomFindBy _continueButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.AccountPage.ContinueButton);

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