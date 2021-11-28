namespace UITests.Terminal.PageObjects.FillRecord
{
    public class TextCustomFieldPage : CommonItems
    {
        private CustomFindBy _pageTitle = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.TextCustomFieldPage.PageTitle);
        private CustomFindBy _textCustomTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.TextCustomFieldPage.TextBox);

        internal void WriteAllInformationOnPage(string customText)
        {
            Session.SendKeys(_textCustomTextBox.GetElement(), customText);
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
