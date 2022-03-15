using System;
using System.Threading;

namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class IdentificationPage : SettingsSideMenu
    {
        private FindBy _enableKeyboardEmulationReadersCheckBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.IdentificationPage.EnableKeyboardEmulationReadersCheckBox);
        private FindBy _dropDownButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.IdentificationPage.DropDownButton);
        private FindBy _dropDownList = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.IdentificationPage.DropDownList);
        private FindBy _testChipReaderButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.IdentificationPage.TestChipReaderButton);

        public void SetEnableKeyboardEmulationReadersCheckBoxState(bool state)
        {
            var element = _enableKeyboardEmulationReadersCheckBox.WaitForElementToBeClickable();

            if (element.Selected == !state)
            {
                element.Click();
            }

            if (element.Selected == !state)
            {
                throw new Exception($"Checkbox was not in correct state");
            }
        }

        public bool IsTestChipReaderButtonVisible()
        {
            Thread.Sleep(500);
            return _testChipReaderButton.GetElement()?.Displayed ?? false;
        }
    }
}
