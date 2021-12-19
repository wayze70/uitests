namespace UITests.Terminal.PageObjects
{
    public class LoginToTerminalSettingsPage
    {
        private CustomFindBy _adminPasswordTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.LoginToTerminalSettingsPage.AdminPasswordTextBox);
        private CustomFindBy _continueButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.LoginToTerminalSettingsPage.ContinueButton);

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
