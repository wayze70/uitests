using System;

namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class AppearancePage : SettingsSideMenu
    {
        private FindBy _titleMainTextBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.AppearancePage.MainTitleTextBox);
        private FindBy _useTerminalNameAsTitleCheckBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.AppearancePage.UseTerminalNameAsTitleCheckBox);
        private FindBy _titleAdditionalTextBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.AppearancePage.AdditionalTitleTextBox);

        public void WriteAllInformationOnThisPage(string mainTitle, string additionTitle)
        {
            Session.SendKeys(_titleMainTextBox.WaitForElementToBeClickable(), mainTitle);
            Session.SendKeys(_titleAdditionalTextBox.WaitForElementToBeClickable(), additionTitle);
        }

        public string GetMainTitle()
        {
            return _titleMainTextBox.WaitForElementIfVisible().Text;
        }

        public void SetUseTerminalNameAsTitleCheckBoxToState(bool state)
        {
            var element = _useTerminalNameAsTitleCheckBox.WaitForElementToBeClickable();

            if (element.Selected == !state)
            {
                element.Click();
            }

            if (element.Selected == !state)
            {
                throw new Exception($"Checkbox was not in correct state");
            }
        }

        public bool GetUseTerminalNameAsTitleCheckBoxState()
        {
            return _useTerminalNameAsTitleCheckBox.WaitForElementIfVisible().Selected;
        }

        public string GetAdditionTitle()
        {
            return _titleAdditionalTextBox.WaitForElementIfVisible().Text;
        }
    }
}
