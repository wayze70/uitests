namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class SubcontractPage : CommonItems
    {
        private FindBy _pageTitle = new FindBy(How.XPath, AutomationLocators.FillRecordPages.SubcontractPage.PageTitel);
        private FindBy _subcontractList = new FindBy(How.ClassName, AutomationLocators.FillRecordPages.SubcontractPage.SubcontractList);

        public void SelectSubcontract(string subcontractName)
        {
            foreach (var item in _subcontractList.WaitForElements())
            {
                if (item.Text == subcontractName)
                {
                    item.Click();
                    break;
                }
            }
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
