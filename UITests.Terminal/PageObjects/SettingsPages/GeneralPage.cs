using System.Threading;

namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class GeneralPage : SettingsSideMenu
    {
        private FindBy _languageComboBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.GeneralPage.LanguageComboBox);
        private FindBy _closeComboBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.GeneralPage.LightDismiss);
        private FindBy _comboBoxItems = new FindBy(How.ClassName, AutomationLocators.SettingsPages.GeneralPage.ComboBoxItems);

        private FindBy _warningMessage = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.GeneralPage.ChangeWillTakeEffectOnApplicationRestart);

        private FindBy _timeFormatComboBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.GeneralPage.TimeFormatComboBox);
        
        private FindBy _newAdminPassword = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.GeneralPage.NewPassword);
        private FindBy _newAdminPasswordCheck = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.GeneralPage.NewPasswordCheck);
        private FindBy _changeAdminPasswordButton = new FindBy(How.Name, AutomationLocators.SettingsPages.GeneralPage.ChangeAdministratorPassword);

        private FindBy _dialogOkButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.GeneralPage.OkButton);
        private FindBy _dialogYesButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.GeneralPage.YesButton);
        private FindBy _dialogNoButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.GeneralPage.NoButton);
        
        public void SelectItemFromLanguageComboBox(string item)
        {
            _languageComboBox.WaitForElementToBeClickable().Click();

            SelectComboBoxItem(item);
        }

        public void SelectItemFromTimeFormatComboBox(string item)
        {
            _timeFormatComboBox.WaitForElementToBeClickable().Click();

            SelectComboBoxItem(item);
        }

        public bool IsWarningMessageVisible()
        {
            Thread.Sleep(500);
            return _warningMessage.GetElement()?.Displayed ?? false;
        }

        public void SetNewPassword(string password, string passwordCheck)
        {
            Session.SendKeys(_newAdminPassword.WaitForElementToBeClickable(), password);
            Session.SendKeys(_newAdminPasswordCheck.WaitForElementToBeClickable(), passwordCheck);
            _changeAdminPasswordButton.WaitForElementToBeClickable().Click();
        }

        public void NewPasswordSuccessfulDialog()
        {
            _dialogOkButton.WaitForElementToBeClickable().Click();
        }

        private void SelectComboBoxItem(string item)
        {
            foreach (var element in _comboBoxItems.WaitForElementsToBeClickable())
            {
                if (element.Text == item)
                {
                    element.Click();
                    break;
                }
            }
        }
    }
}
