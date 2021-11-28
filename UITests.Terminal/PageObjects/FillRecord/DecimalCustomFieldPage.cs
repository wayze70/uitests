namespace UITests.Terminal.PageObjects.FillRecord
{
    public class DecimalCustomFieldPage : CommonItems
    {
        private CustomFindBy _pageTitle = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.DecimalCustomFieldPage.PageTitle);
        private CustomFindBy _deciamlTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.DecimalCustomFieldPage.DecimalTextBox);

        public void WriteAllInformationOnPage(double number)
        {
            Session.SendKeys(_deciamlTextBox.GetElement(), number.ToString());
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
