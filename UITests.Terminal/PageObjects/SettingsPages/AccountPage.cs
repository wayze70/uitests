namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class AccountPage : SettingsSideMenu
    {
        private FindBy _logoutButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.AccountPage.LogoutButton);

        public void ClickToLogoutButton()
        {
            _logoutButton.WaitForElementToBeClickable().Click();
        }
    }
}
