namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class DescriptionPage : CommonItems
    {
        private FindBy _pageTitle = new FindBy(How.XPath, AutomationLocators.FillRecordPages.DescriptionPage.PageTitel);
        private FindBy _descriptionTextBox = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.DescriptionPage.DescriptionTextBox);

        public void WriteAllInformationOnPage(string description)
        {
            Session.SendKeys(_descriptionTextBox.WaitForElementToBeClickable(), description);
        }

        public string GetPageValue()
        {
            return _descriptionTextBox.WaitForElementIfVisible().Text;
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
