using System.Linq;

namespace UITests.Terminal.PageObjects.Terminal
{
    public class TerminalPage : HamburgerMenu
    {
        private CustomFindBy _activityList = new CustomFindBy(How.AccessibilityId, AutomationLocators.Terminal.TerminalPage.ActivityList);

        public void ClickToActivity()
        {
            var elements = _activityList.WaitForElements();
            elements.ElementAt(0).Click();
        }
    }
}
