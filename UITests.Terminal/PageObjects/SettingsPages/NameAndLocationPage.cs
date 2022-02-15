using NUnit.Framework;
using System.Threading;

namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class NameAndLocationPage : SettingsSideMenu
    {
        private FindBy _deviceNameTextBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.NameAndLocationPage.DeviceNameTextBox);
        private FindBy _errorMassageTextBlock = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.NameAndLocationPage.ErrorMessageTextBlock);
        private FindBy _locationAddressComboBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.NameAndLocationPage.LocationAddressComboBox);
        private FindBy _clearButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.NameAndLocationPage.ClearButton);
        private FindBy _mapPopupButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.NameAndLocationPage.ExtraButton);

        public string GetDeviceName()
        {
            return _deviceNameTextBox.WaitForElementIfVisible().Text;
        }

        public void ClearDeviceName()
        {
            _deviceNameTextBox.WaitForElementToBeClickable().Clear();
        }

        public void SetDeviceName(string deviceName)
        {
            var element = _deviceNameTextBox.WaitForElementToBeClickable();

            element.Clear();
            _errorMassageTextBlock.WaitForElementIfVisible();
            element.SendKeys(deviceName);

            Assert.AreEqual(deviceName, element.Text);
        }

        public void ClickToLocationClearButton()
        {
            _clearButton.WaitForElementToBeClickable().Click();
        }

        public void ClickToLocationMapPopupButton()
        {
            _mapPopupButton.WaitForElementToBeClickable().Click();
        }
    }
}
