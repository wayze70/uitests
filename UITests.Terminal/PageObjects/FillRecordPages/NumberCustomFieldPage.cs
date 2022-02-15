namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class NumberCustomFieldPage : CommonItems
    {
        private FindBy _pageTitle = new FindBy(How.XPath, AutomationLocators.FillRecordPages.NumberCustomFieldPage.PageTitle);
        private FindBy _numericTextBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.NumberCustomFieldPage.NumberCustomTextBox);

        public void WriteAllInformationOnPage(int number)
        {
            Session.SendKeys(_numericTextBox.WaitForElementToBeClickable(), number.ToString());
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
