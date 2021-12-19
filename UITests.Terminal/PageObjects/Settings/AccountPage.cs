namespace UITests.Terminal.PageObjects.Settings
{
    public class AccountPage : SettingsSideMenu
    {
        private CustomFindBy _logoutButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.AccountPage.LogoutButton);


        public void ClickToLogoutButton()
        {
            _logoutButton.WaitForElementToBeClickable().Click();
        }
    }
}
