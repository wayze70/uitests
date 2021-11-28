using System;

namespace UITests.Terminal.PageObjects.FillRecord
{
    public class BillablePage : CommonItems
    {
        private CustomFindBy _pageTitle = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.BillablePage.PageTitel);
        private CustomFindBy _toggleSwitch = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.BillablePage.ToggleSwitch);

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
