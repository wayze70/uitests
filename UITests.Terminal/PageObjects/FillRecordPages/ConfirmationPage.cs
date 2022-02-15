namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class ConfirmationPage
    {
        private FindBy _fillAdditionalInfoButton = new FindBy(How.AccessibilityId, AutomationLocators.ConfirmationPage.FillAdditionalInfoButton);

        public void ClickToFillAdditionalInfoButton()
        {
            _fillAdditionalInfoButton.WaitForElementToBeClickable().Click();
        }

        public void WaitForFillAdditionalInfoButton()
        {
            _fillAdditionalInfoButton.WaitForElementIfVisible();
        }
    }
}
