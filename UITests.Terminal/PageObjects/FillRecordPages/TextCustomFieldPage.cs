namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class TextCustomFieldPage : CommonItems
    {
        private FindBy _pageTitle = new FindBy(How.XPath, AutomationLocators.FillRecordPages.TextCustomFieldPage.PageTitle);
        private FindBy _textCustomTextBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.TextCustomFieldPage.TextCustomTextBox);

        internal void WriteAllInformationOnPage(string customText)
        {
            Session.SendKeys(_textCustomTextBox.WaitForElementToBeClickable(), customText);
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
