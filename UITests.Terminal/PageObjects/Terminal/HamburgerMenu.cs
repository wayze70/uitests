namespace UITests.Terminal.PageObjects.Terminal
{
    public class HamburgerMenu
    {
        private CustomFindBy _hamburgerMenuToggleButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.Terminal.HamburgerMenu.HamburgerMenuToggleButton);
        private CustomFindBy _terminal = new CustomFindBy(How.AccessibilityId, AutomationLocators.Terminal.HamburgerMenu.TerminalMenuItem);
        private CustomFindBy _summary = new CustomFindBy(How.AccessibilityId, AutomationLocators.Terminal.HamburgerMenu.SummaryMenuItem);
        private CustomFindBy _logout = new CustomFindBy(How.AccessibilityId, AutomationLocators.Terminal.HamburgerMenu.LogoutMenuItem);
        private CustomFindBy _settings = new CustomFindBy(How.AccessibilityId, AutomationLocators.Terminal.HamburgerMenu.SettingsMenuItem);

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
