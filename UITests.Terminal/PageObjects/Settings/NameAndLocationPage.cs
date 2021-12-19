namespace UITests.Terminal.PageObjects.Settings
{
    public class NameAndLocationPage : SettingsSideMenu
    {
        private CustomFindBy _deviceNameTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.NameAndLocationPage.DeviceNameTextBox);
        private CustomFindBy _locationAddressComboBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.NameAndLocationPage.LocationAddressComboBox);

        public string GetDeviceName()
        {
            return _deviceNameTextBox.GetElement().Text;
        }
    }
}
