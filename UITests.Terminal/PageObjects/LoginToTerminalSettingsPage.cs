namespace UITests.Terminal.PageObjects
{
    public class LoginToTerminalSettingsPage
    {
        private CustomFindBy _adminPassword = new CustomFindBy(How.AccessibilityId, AutomationLocators.LoginToTerminalSettingsPage.AdminPassword);
        private CustomFindBy _continueButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.LoginToTerminalSettingsPage.Continue);

        public void WriteAllInformationOnPage(string adminPassword)
        {
            Session.SendKeys(_adminPassword.WaitForElementToBeClickable(), adminPassword);
        }

        public void ClickToContinueButton()
        {
            _continueButton.WaitForElementToBeClickable().Click();
        }
    }
}
