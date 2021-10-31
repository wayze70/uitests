namespace UITests.Terminal.PageObjects.Terminal
{
    public class SummaryPage : HamburgerMenu
    {
        private CustomFindBy _pageTitel = new CustomFindBy(How.AccessibilityId, AutomationLocators.Terminal.SummaryPage.PageTitel);
        private CustomFindBy _monthTotal = new CustomFindBy(How.AccessibilityId, AutomationLocators.Terminal.SummaryPage.ThisMonthTotal);

        public void PageContentMustBeVisible()
        {
            _pageTitel.WaitForElementIfVisible();
            _monthTotal.WaitForElementIfVisible();
        }
    }
}
