namespace UITests.Terminal.PageObjects.Login
{
    public class WelcomePage
    {
        private CustomFindBy _startTheSetupWizard = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.WelcomePage.StartWizardButton);

        public bool IsStartTheSetupWizzardDisplayed()
        {
            return _startTheSetupWizard.GetElement()?.Displayed ?? false;
        }

        public void ClickToStartTheSetupWizzard()
        {
            _startTheSetupWizard.WaitForElementToBeClickable().Click();
        }
    }
}
