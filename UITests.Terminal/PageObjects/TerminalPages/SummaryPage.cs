namespace UITests.Terminal.PageObjects.TerminalPages
{
    public class SummaryPage : HamburgerMenu
    {
        private FindBy _pageTitel = new FindBy(How.AccessibilityId, AutomationLocators.TerminalPages.SummaryPage.PageTitel);
        private FindBy _monthTotal = new FindBy(How.AccessibilityId, AutomationLocators.TerminalPages.SummaryPage.ThisMonthTotalTextBlock);

        public void WaitForPageContent()
        {
            _pageTitel.WaitForElementIfVisible();
            _monthTotal.WaitForElementIfVisible();
        }
    }
}
