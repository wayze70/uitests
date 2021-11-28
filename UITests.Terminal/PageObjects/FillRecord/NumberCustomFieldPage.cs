namespace UITests.Terminal.PageObjects.FillRecord
{
    public class NumberCustomFieldPage : CommonItems
    {
        private CustomFindBy _pageTitle = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.NumberCustomFieldPage.PageTitle);
        private CustomFindBy _numericTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.NumberCustomFieldPage.NumericTextBox);

        public void WriteAllInformationOnPage(int number)
        {
            Session.SendKeys(_numericTextBox.GetElement(), number.ToString());
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
