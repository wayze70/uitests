using System.Threading;

namespace UITests.Terminal.PageObjects
{
    public class HomePage
    {
        private FindBy _time = new FindBy(How.AccessibilityId, AutomationLocators.HomePage.TimeTextBlock);
        private FindBy _goToSettings = new FindBy(How.AccessibilityId, AutomationLocators.HomePage.GoToSettingButton);
        private FindBy _settings = new FindBy(How.AccessibilityId, AutomationLocators.HomePage.SettingsButton);
        private FindBy _enterPin = new FindBy(How.AccessibilityId, AutomationLocators.HomePage.EnterPinTextBlock);
        private FindBy _mainTitleTextBlock = new FindBy(How.AccessibilityId, AutomationLocators.HomePage.MainTitleTextBlock);
        private FindBy _additionTitleTextBlock = new FindBy(How.AccessibilityId, AutomationLocators.HomePage.AdditionalTitleTextBlock);
        private FindBy _messageTextBlock = new FindBy(How.AccessibilityId, AutomationLocators.HomePage.MessageTextBlock);

        public bool IsMessageTextBlockVisible()
        {
            Thread.Sleep(500);
            return _messageTextBlock.WaitForElementIfVisible().Text == "Plug in reader or allow access by entering the PIN";
        }

        public void ClickToGoToSettings()
        {
            _goToSettings.WaitForElementToBeClickable().Click();
        }

        public void ClickToSettings()
        {
            _settings.WaitForElementToBeClickable().Click();
        }

        public void ClickToEnterPin()
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
