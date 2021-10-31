namespace UITests.Terminal.PageObjects.FillRecord
{
    public class DescriptionPage
    {
        private CustomFindBy _descriptionTextBox = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.DescriptionPage.TextBox);

        public void WriteAllInformationOnPage(string description)
        {
            Session.SendKeys(_descriptionTextBox.GetElement(), description);
        }
    }
}
