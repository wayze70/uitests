namespace UITests.Terminal.PageObjects.SetupPages
{
    public class PasswordPage
    {
        private FindBy _adminPassword = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.PasswordPage.AdminPasswordTextBox);
        private FindBy _adminPasswordCheck = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.PasswordPage.AdminPasswordCheckTextBox);
        private FindBy _finishButton = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.PasswordPage.ContinueButton);

        public void WriteAllInformationOnPage(string password, string passwordCheck)
        {
            Session.SendKeys(_adminPassword.WaitForElementToBeClickable(), password);
            Session.SendKeys(_adminPasswordCheck.WaitForElementToBeClickable(), passwordCheck);
        }

        public void ClickToFinishButton()
        {
            _finishButton.WaitForElementToBeClickable().Click();
        }
    }
}
