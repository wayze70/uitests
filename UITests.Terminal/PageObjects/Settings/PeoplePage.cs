using OpenQA.Selenium.Appium.Windows;
using System.Collections.Generic;

namespace UITests.Terminal.PageObjects.Settings
{
    public class PeoplePage : SettingsSideMenu
    {
        private CustomFindBy _peopleList = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.PeoplePage.PeopleList);
        private CustomFindBy _pinCheckBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.PeoplePage.PinCheckBox);
        private CustomFindBy _pinTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.PeoplePage.PinTextBox);

        public IReadOnlyCollection<WindowsElement> GetPeopleList()
        {
            return _peopleList.GetElements();
        }

        public bool IsPinCheckBoxChecked()
        {
            return _pinCheckBox.GetElement().Selected;
        }

        public void ChangePinCheckBoxState()
        {
            _pinCheckBox.WaitForElementToBeClickable().Click();
        }

        public void SetPin(int pin)
        {
            Session.SendKeys(_pinTextBox.GetElement(), pin.ToString());
        }
    }
}
