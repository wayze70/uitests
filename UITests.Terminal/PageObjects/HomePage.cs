namespace UITests.Terminal.PageObjects
{
    public class HomePage
    {
        private CustomFindBy _time = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.TimeTextBlock);
        private CustomFindBy _goToSettings = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.GoToSettingButton);
        private CustomFindBy _settings = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.SettingsButton);
        private CustomFindBy _enterPin = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.EnterPin);
        private CustomFindBy _mainTitleTextBlock = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.TopLeftTitleTextBlock);
        private CustomFindBy _additionTitleTextBlock = new CustomFindBy(How.AccessibilityId, AutomationLocators.HomePage.TitleAdditionalTextBlock);

        public void ClickToEnterPin()
        {
            _enterPin.WaitForElementToBeClickable().Click();
        }

        public void ClickToGoToSettings()
        {
            _goToSettings.WaitForElementToBeClickable().Click();
        }

        public void ClickToSettings()
        {
            _settings.WaitForElementToBeClickable().Click();
        }

        public void WaitForPage()
        {
            _time.WaitForElementIfVisible();
            _goToSettings.WaitForElementIfVisible();
            _settings.WaitForElementIfVisible();
            _enterPin.WaitForElementIfVisible();
        }

        public string GetMainTitle()
        {
            return _mainTitleTextBlock.WaitForElementIfVisible().Text;
        }

        public string GetAdditionTitle()
        {
            return _additionTitleTextBlock.WaitForElementIfVisible().Text;
        }
    }
}
