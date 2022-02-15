using System.Threading;

namespace UITests.Terminal.PageObjects.SetupPages
{
    public class WelcomePage
    {
        private FindBy _startTheSetupWizard = new FindBy(How.AccessibilityId, AutomationLocators.SetupPages.WelcomePage.StartWizardButton);

        public bool IsStartTheSetupWizzardVisible()
        {
            Thread.Sleep(500);
            return _startTheSetupWizard.GetElement()?.Displayed ?? false;
        }

        public void ClickToStartTheSetupWizzard()
        {
            _startTheSetupWizard.WaitForElementToBeClickable().Click();
        }
    }
}
