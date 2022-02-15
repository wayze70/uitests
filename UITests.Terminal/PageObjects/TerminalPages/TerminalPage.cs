using System.Linq;

namespace UITests.Terminal.PageObjects.TerminalPages
{
    public class TerminalPage : HamburgerMenu
    {
        private FindBy _activityList = new FindBy(How.AccessibilityId, AutomationLocators.TerminalPages.TerminalPage.ActivityList);

        public void ClickToActivity()
        {
            _activityList.WaitForElements().ElementAt(0).Click();
        }
    }
}
