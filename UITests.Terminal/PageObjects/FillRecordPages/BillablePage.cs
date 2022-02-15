using System;

namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class BillablePage : CommonItems
    {
        private FindBy _pageTitle = new FindBy(How.XPath, AutomationLocators.FillRecordPages.BillablePage.PageTitel);
        private FindBy _toggleSwitch = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.BillablePage.BillableToggleSwitch);

        public void SetToggleSwitchState(bool state)
        {
            var element = _toggleSwitch.WaitForElementToBeClickable();

            if (element.Selected != state)
            {
                element.Click();
            }
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
