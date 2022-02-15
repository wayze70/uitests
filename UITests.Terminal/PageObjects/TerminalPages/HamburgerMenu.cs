namespace UITests.Terminal.PageObjects.TerminalPages
{
    public class HamburgerMenu
    {
        private FindBy _hamburgerMenuToggleButton = new FindBy(How.AccessibilityId, AutomationLocators.TerminalPages.HamburgerMenu.HamburgerMenuToggleButton);
        private FindBy _terminal = new FindBy(How.AccessibilityId, AutomationLocators.TerminalPages.HamburgerMenu.TerminalMenuItemButton);
        private FindBy _summary = new FindBy(How.AccessibilityId, AutomationLocators.TerminalPages.HamburgerMenu.SummaryMenuItemButton);
        private FindBy _logout = new FindBy(How.AccessibilityId, AutomationLocators.TerminalPages.HamburgerMenu.LogoutMenuItemButton);
        private FindBy _settings = new FindBy(How.AccessibilityId, AutomationLocators.TerminalPages.HamburgerMenu.SettingsMenuItemButton);

        public void ClickToHambuerMenuToggleButton()
        {
            _hamburgerMenuToggleButton.WaitForElementToBeClickable().Click();
        }

        public void ClickToTerminalMenuItem()
        {
            _terminal.WaitForElementToBeClickable().Click();
        }

        public void ClickToSummaryMenuItem()
        {
            _summary.WaitForElementToBeClickable().Click();
        }

        public void ClickToLogoutMenuItem()
        {
            _logout.WaitForElementToBeClickable().Click();
        }

        public void ClickToSettingsMenuItem()
        {
            _settings.WaitForElementToBeClickable().Click();
        }
    }
}
