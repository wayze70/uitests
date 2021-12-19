namespace UITests.Terminal.PageObjects.Settings
{
    public class AppearancePage : SettingsSideMenu
    {
        private CustomFindBy _titleMainTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.AppearancePage.TitleMainTextBox);
        private CustomFindBy _useTerminalNameAsTitleCheckBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.AppearancePage.UseTerminalNameAsTitleCheckBox);
        private CustomFindBy _titleAdditionalTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.AppearancePage.TitleAdditionalTextBox);

        public void WriteAllInformationOnThisPage(string mainTitle, string additionTitle, bool clearContentBeforeEdditing = false)
        {
            var mainTitleTextBox = _titleMainTextBox.GetElement();
            var additionTitleTextBox = _titleAdditionalTextBox.GetElement();


            if (clearContentBeforeEdditing)
            {
                mainTitleTextBox.Clear();
                additionTitleTextBox.Clear();
            }

            Session.SendKeys(mainTitleTextBox, mainTitle);
            Session.SendKeys(additionTitleTextBox, additionTitle);
        }

        public string GetMainTitle()
        {
            return _titleMainTextBox.GetElement().Text;
        }

        public void SetUseTerminalNameAsTitleCheckBoxToState(bool state)
        {
            var element = _useTerminalNameAsTitleCheckBox.WaitForElementToBeClickable();

            if (element.Selected == !state)
            {
                element.Click();
            }
        }

        public bool GetUseTerminalNameAsTitleCheckBoxState()
        {
            return _useTerminalNameAsTitleCheckBox.GetElement().Selected;
        }

        public string GetAdditionTitle()
        {
            return _titleAdditionalTextBox.GetElement().Text;
        }
    }
}
