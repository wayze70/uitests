namespace UITests.Terminal.PageObjects.FillRecord
{
    public class CommonItems
    {
        private CustomFindBy _cancelButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.CommonItems.CancelButton);
        private CustomFindBy _nextPageButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.CommonItems.NextPageButton);
        private CustomFindBy _previousPageButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.CommonItems.PreviousPageButton);

        public void ClickToCancelButton()
        {
            _cancelButton.WaitForElementToBeClickable().Click();
        }

        public void ClickToNextPageButton()
        {
            _nextPageButton.WaitForElementToBeClickable().Click();
        }

        public void PreviousPageButton()
        {
            _previousPageButton.WaitForElementToBeClickable().Click();
        }
    }
}
