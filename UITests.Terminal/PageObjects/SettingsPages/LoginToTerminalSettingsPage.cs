namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class LoginToTerminalSettingsPage
    {
        private FindBy _adminPasswordTextBox = new FindBy(How.AccessibilityId, AutomationLocators.LoginToTerminalSettingsPage.AdminPasswordTextBox);
        private FindBy _continueButton = new FindBy(How.AccessibilityId, AutomationLocators.LoginToTerminalSettingsPage.ContinueButton);

        public void WriteAllInformationOnPage(string adminPassword)
        {
            Session.SendKeys(_adminPasswordTextBox.WaitForElementToBeClickable(), adminPassword);
        }

        public void ClickToContinueButton()
        {
            _continueButton.WaitForElementToBeClickable().Click();
        }
    }
}
