namespace UITests.Terminal.PageObjects
{
    public class ConfirmationPage
    {
        private CustomFindBy _fillAdditionalInfoButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.ConfirmationPage.FillAdditionalInfoButton);

        public void ClickToFillAdditionalInfoButton()
        {
            _fillAdditionalInfoButton.WaitForElementToBeClickable().Click();
        }

        public void CheckIfFillAdditionalInfoButtonIsVisible()
        {
            _fillAdditionalInfoButton.WaitForElementIfVisible();
        }
    }
}
