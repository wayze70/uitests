namespace UITests.Terminal.PageObjects.SetupPages
{
    public class NameAndLocationPage
    {
        private FindBy _deviceName = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.NameAndLocationPage.DeviceNameTextBox);
        private FindBy _locationAddress = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.NameAndLocationPage.LocationAdressComboBox);
        private FindBy _locationClear = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.NameAndLocationPage.LocationClearButton);
        private FindBy _mapPopup = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.NameAndLocationPage.MapPopUpButton);
        private FindBy _continueButton = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.NameAndLocationPage.ContinueButton);

        public void WriteAllInformationOnPage(string deviceName)
        {
            Session.SendKeys(_deviceName.WaitForElementToBeClickable(), deviceName);
            _mapPopup.WaitForElementToBeClickable().Click();
            PageFactory.CommonPages.LocationPopupPage.SelectLocationFromMap();
        }

        public void ClickToContinueButton()
        {
            _continueButton.WaitForElementToBeClickable().Click();
        }
    }
}
