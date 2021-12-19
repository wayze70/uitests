namespace UITests.Terminal.PageObjects.FillRecord
{
    public class CommonItems
    {
        private CustomFindBy _cancelButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.CommonItems.CancelButton);
        private CustomFindBy _nextPageButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.CommonItems.NextPageButton);
        private CustomFindBy _previousPageButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.CommonItems.PreviousPageButton);

        private CustomFindBy _confirmButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.CommonItems.ConfirmButton);
        private CustomFindBy _declineButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.CommonItems.DeclineButton);

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
