namespace UITests.Terminal.PageObjects.FillRecord
{
    public class YesNoCustomFieldPage : CommonItems
    {
        private CustomFindBy _pageTitle = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.YesNoCustomFieldPage.PageTitle);
        private CustomFindBy _toggleSwitch = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.YesNoCustomFieldPage.ToggleSwitch);

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
