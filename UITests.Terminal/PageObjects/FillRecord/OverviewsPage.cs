﻿using System;
using System.Text.RegularExpressions;

namespace UITests.Terminal.PageObjects.FillRecord
{
    public class OverviewPage
    {
        private CustomFindBy _settingsButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.SettingsButton);
        private CustomFindBy _declineButton = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.OverviewPage.DeclineButton);
        private CustomFindBy _confirmButton = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.OverviewPage.ConfirmButton);

        private CustomFindBy _descriptionTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.DescriptionTextBox);
        private CustomFindBy _contractComboBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.ContractComboBox);
        private CustomFindBy _subcontractComboBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.SubcontractComboBox);
        private CustomFindBy _billableToggleSwitch = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.BillableToggleSwitch);
        private CustomFindBy _listCustomFieldComboBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.ListCustomFieldComboBox);
        private CustomFindBy _textCustomFieldTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.TextCustomFieldTextBox);
        private CustomFindBy _numberCustomFieldTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.NumberCustomFieldTextBox);
        private CustomFindBy _decimalCustomFieldTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.DecimalCustomFieldTextBox);
        private CustomFindBy _yesNoToggleSwitch = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewPage.YesNoToggleSwitch);

        public string CheckDescriptionValue()
        {
            return _descriptionTextBox.GetElement().Text;
        }

        public string CheckContractValue()
        {
            return _contractComboBox.GetElement().Text;
        }

        public string CheckSubcontractValue()
        {
            return _subcontractComboBox.GetElement().Text;
        }

        public bool CheckBillableValue()
        {
            return _billableToggleSwitch.GetElement().Selected;
        }

        public string CheckListCustomFieldValue()
        {
            return _listCustomFieldComboBox.GetElement().Text;
        }

        public string CheckTextCustomFieldValue()
        {
            return _textCustomFieldTextBox.GetElement().Text;
        }

        public int CheckNumberCustomFieldValue()
        {
            return Convert.ToInt32(_numberCustomFieldTextBox.GetElement().Text.Replace(",", string.Empty));
        }

        public double CheckDecimalCustomFieldValue()
        {
            return Convert.ToDouble(_decimalCustomFieldTextBox.GetElement().Text.Replace(",", string.Empty));
        }

        public bool CheckYesNoCustomFieldValue()
        {
            return _yesNoToggleSwitch.GetElement().Selected;
        }

        public void ClickToConfirmButton()
        {
            _confirmButton.WaitForElementToBeClickable().Click();
        }
    }
}