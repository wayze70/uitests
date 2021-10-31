namespace UITests.Terminal.PageObjects.Login
{
    public class NameAndLocationPage
    {
        private CustomFindBy _deviceName = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.NameAndLocationPage.DeviceNameTextBox);
        private CustomFindBy _locationAddress = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.NameAndLocationPage.LocationAdressComboBox);
        private CustomFindBy _locationClear = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.NameAndLocationPage.LocationClearButton);
        private CustomFindBy _mapPopUp = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.NameAndLocationPage.MapPopUpButton);
        private CustomFindBy _continueButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.NameAndLocationPage.ContinueButton);

        public void WriteAllInformationOnPage(string deviceName)
        {
            Session.SendKeys(_deviceName.WaitForElementToBeClickable(), deviceName);
            _mapPopUp.WaitForElementToBeClickable().Click();
            PageFactory.LocationPopUp.SelectLocationFromMap();
        }

        public void ClickToContinueButton()
        {
            _continueButton.WaitForElementToBeClickable().Click();
        }
    }
}
