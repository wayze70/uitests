namespace UITests.Terminal.PageObjects.FillRecord
{
    public class SubcontractPage : CommonItems
    {
        private CustomFindBy _pageTitle = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.SubcontractPage.PageTitel);
        private CustomFindBy _subcontractList = new CustomFindBy(How.ClassName, AutomationLocators.FillRecord.SubcontractPage.SubcontractList);

        public void SelectSubcontract(string subcontract)
        {
            foreach (var item in _subcontractList.WaitForElements())
            {
                if (item.Text == subcontract)
                {
                    item.Click();
                }
            }
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
