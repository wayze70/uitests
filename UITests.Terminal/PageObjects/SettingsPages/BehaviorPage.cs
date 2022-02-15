using System;

namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class BehaviorPage : SettingsSideMenu
    {
        private FindBy _setLoginPageAsDefultCheckBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.BehaviorPage.SetLoginPageAsDefultCheckBox);
        private FindBy _timeToSelectTextBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.BehaviorPage.TimeToSelectTextBox);

        public bool GetSetLoginPageAsDefultCheckBoxState()
        {
            return _setLoginPageAsDefultCheckBox.WaitForElementIfVisible().Selected;
        }

        public void SetSetLoginPageAsDefultCheckBoxState(bool state)
        {
            var element = _setLoginPageAsDefultCheckBox.WaitForElementToBeClickable();

            if (element.Selected == !state)
            {
                element.Click();
            }

            if (element.Selected == !state)
            {
                throw new Exception($"Checkbox was not in correct state");
            }
        }
    }
}
