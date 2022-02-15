namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class SettingsPage
    {
        private FindBy _backButton = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewSettingsPage.BackButton);

        private FindBy _startFillInOtherInformationAutomatically = new FindBy(How.AccessibilityId, AutomationLocators.FillRecordPages.OverviewSettingsPage.StartFillInOtherInformationAutomaticallyCheckBox);

        public void CheckIfStartFillInOtherInformationAutomaticallyIsVisible()
        {
            _startFillInOtherInformationAutomatically.WaitForElementIfVisible();
        }

        public void ClickToBackButton()
        {
            _backButton.WaitForElementToBeClickable().Click();
        }
    }
}
