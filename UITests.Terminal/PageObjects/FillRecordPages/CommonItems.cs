namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class CommonItems
    {
        private FindBy _cancelButton = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.CommonItems.CancelButton);
        private FindBy _nextPageButton = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.CommonItems.NextPageButton);
        private FindBy _previousPageButton = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.CommonItems.PreviousPageButton);

        private FindBy _confirmButton = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.CommonItems.ConfirmButton);
        private FindBy _declineButton = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.CommonItems.DeclineButton);

        public void ClickToCancelButton()
        {
            _cancelButton.WaitForElementToBeClickable().Click();
        }

        public void ClickToNextPageButton()
        {
            _nextPageButton.WaitForElementToBeClickable().Click();
        }

        public void ClickToPreviousPageButton()
        {
            _previousPageButton.WaitForElementToBeClickable().Click();
        }

        public void ClickToConfirmEditButton()
        {
            _confirmButton.WaitForElementToBeClickable().Click();
        }

        public void ClickToDeclineEditButton()
        {
            _declineButton.WaitForElementToBeClickable().Click();
        }
    }
}
