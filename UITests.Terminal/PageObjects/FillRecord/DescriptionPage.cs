namespace UITests.Terminal.PageObjects.FillRecord
{
    public class DescriptionPage : CommonItems
    {
        private CustomFindBy _pageTitle = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.DescriptionPage.PageTitel);
        private CustomFindBy _descriptionTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.DescriptionPage.TextBox);

        public void WriteAllInformationOnPage(string description, bool clearContentBeforeEditing = false)
        {
            if (clearContentBeforeEditing)
            {
                _descriptionTextBox.GetElement().Clear();
            }

            Session.SendKeys(_descriptionTextBox.GetElement(), description);
        }

        public string GetPageValue()
        {
            return _descriptionTextBox.GetElement().Text;
        }

        public string GetPageTitle()
        {
            return _pageTitle.GetElement().Text;
        }
    }
}
