using System;

namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class OverviewPage
    {
        private FindBy _settingsButton = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.SettingsButton);
        private FindBy _declineButton = new FindBy(How.XPath, AutomationLocators.FillRecordPages.OverviewPage.DeclineButton);
        private FindBy _confirmButton = new FindBy(How.XPath, AutomationLocators.FillRecordPages.OverviewPage.ConfirmButton);

        private FindBy _descriptionTextBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.DescriptionTextBox);
        private FindBy _contractComboBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.ContractComboBox);
        private FindBy _subcontractComboBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.SubcontractComboBox);
        private FindBy _billableToggleSwitch = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.BillableToggleSwitch);
        private FindBy _listCustomFieldComboBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.ListCustomFieldComboBox);
        private FindBy _textCustomFieldTextBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.TextCustomFieldTextBox);
        private FindBy _numberCustomFieldTextBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.NumberCustomFieldTextBox);
        private FindBy _decimalCustomFieldTextBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.DecimalCustomFieldTextBox);
        private FindBy _yesNoCustomFieldToggleSwitch = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewPage.YesNoCustomFieldToggleSwitch);

        public string GetDescriptionValue()
        {
            return _descriptionTextBox.WaitForElementIfVisible().Text;
        }

        public string GetContractValue()
        {
            return _contractComboBox.WaitForElementIfVisible().Text;
        }

        public string GetSubcontractValue()
        {
            return _subcontractComboBox.WaitForElementIfVisible().Text;
        }

        public bool GetBillableValue()
        {
            return _billableToggleSwitch.WaitForElementIfVisible().Selected;
        }

        public string GetListCustomFieldValue()
        {
            return _listCustomFieldComboBox.WaitForElementIfVisible().Text;
        }

        public string GetTextCustomFieldValue()
        {
            return _textCustomFieldTextBox.WaitForElementIfVisible().Text;
        }

        public int GetNumberCustomFieldValue()
        {
            return Convert.ToInt32(_numberCustomFieldTextBox.WaitForElementIfVisible().Text.Replace(",", string.Empty));
        }

        public double GetDecimalCustomFieldValue()
        {
            return Convert.ToDouble(_decimalCustomFieldTextBox.WaitForElementIfVisible().Text.Replace(",", string.Empty));
        }

        public bool GetYesNoCustomFieldValue()
        {
            return _yesNoCustomFieldToggleSwitch.WaitForElementIfVisible().Selected;
        }

        public void WaitForDeclineButton()
        {
            _declineButton.WaitForElementIfVisible();
        }

        public void ClickToConfirmButton()
        {
            _confirmButton.WaitForElementToBeClickable().Click();
        }

        public void ClickToSettingsButton()
        {
            _settingsButton.WaitForElementToBeClickable().Click();
        }
        public void ClickToDescription()
        {
            _descriptionTextBox.WaitForElementToBeClickable().Click();
        }

        public void ClickToContract()
        {
            _contractComboBox.WaitForElementToBeClickable().Click();
        }

        public void ClickToSubcontract()
        {
            _subcontractComboBox.WaitForElementToBeClickable().Click();
        }

        public void ClickToBillable()
        {
            _billableToggleSwitch.WaitForElementToBeClickable().Click();
        }

        public void ClickToListCustomField()
        {
            _listCustomFieldComboBox.WaitForElementToBeClickable().Click();
        }

        public void ClickToTextCustomField()
        {
            _textCustomFieldTextBox.WaitForElementToBeClickable().Click();
        }

        public void ClickToNumberCustomField()
        {
            _numberCustomFieldTextBox.WaitForElementToBeClickable().Click();
        }

        public void ClickToDecimalCustomField()
        {
            _decimalCustomFieldTextBox.WaitForElementToBeClickable().Click();
        }

        public void ClickToYesNoCustomField()
        {
            _yesNoCustomFieldToggleSwitch.WaitForElementToBeClickable().Click();
        }
    }
}
