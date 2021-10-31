namespace UITests.Terminal.PageObjects
{
    public class HomePage
    {
        public CustomFindBy _time = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.TimeTextBlock);
        public CustomFindBy _goToSettings = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.GoToSettingButton);
        public CustomFindBy _settings = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.SettingsButton);
        public CustomFindBy _enterPin = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.EnterPin);

        public void ClickToEnterPin()
        {
            _enterPin.WaitForElementToBeClickable().Click();
        }

        public void ClickToGoToSettings()
        {
            _enterPin.WaitForElementToBeClickable().Click();
        }

        public void ClickToSettings()
        {
            _enterPin.WaitForElementToBeClickable().Click();
        }

        public void WaitForPage()
        {
            _time.WaitForElementIfVisible();
            _goToSettings.WaitForElementIfVisible();
            _settings.WaitForElementIfVisible();
            _enterPin.WaitForElementIfVisible();
        }
    }
}
