namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class DecimalCustomFieldPage : CommonItems
    {
        private FindBy _pageTitle = new FindBy(How.XPath, AutomationLocators.FillRecordPages.DecimalCustomFieldPage.PageTitle);
        private FindBy _deciamlTextBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.DecimalCustomFieldPage.DecimalCustomTextBox);

        public void WriteAllInformationOnPage(double number)
        {
            Session.SendKeys(_deciamlTextBox.WaitForElementToBeClickable(), number.ToString());
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
