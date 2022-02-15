namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class YesNoCustomFieldPage : CommonItems
    {
        private FindBy _pageTitle = new FindBy(How.XPath, AutomationLocators.FillRecordPages.YesNoCustomFieldPage.PageTitle);
        private FindBy _toggleSwitch = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.YesNoCustomFieldPage.YesNoCustomToggleSwitch);

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
