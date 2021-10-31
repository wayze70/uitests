namespace UITests.Terminal.PageObjects.Login
{
    public class PasswordPage
    {
        private CustomFindBy _adminPassword = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.PasswordPage.AdminPassword);
        private CustomFindBy _adminPasswordCheck = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.PasswordPage.AdminPasswordCheck);
        private CustomFindBy _finishButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.PasswordPage.ContinueButton);

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
