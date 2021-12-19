namespace UITests.Terminal.PageObjects.FillRecord
{
    public class SettingsPage
    {
        private CustomFindBy _backButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewSettingsPage.BackButton);

        private CustomFindBy _startFillInOtherInformationAutomatically = new CustomFindBy(How.AccessibilityId, AutomationLocators.FillRecord.OverviewSettingsPage.StartFillInOtherInformationAutomatically);

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
