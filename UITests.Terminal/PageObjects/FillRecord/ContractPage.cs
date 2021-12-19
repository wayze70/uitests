namespace UITests.Terminal.PageObjects.FillRecord
{
    public class ContractPage : CommonItems
    {
        private CustomFindBy _pageTitel = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.ContractPage.PageTitel);
        private CustomFindBy _contractList = new CustomFindBy(How.ClassName, AutomationLocators.FillRecord.ContractPage.ContractList);

        public void SelectContract(string contract)
        {
            foreach (var item in _contractList.WaitForElementsToBeClickable())
            {
                if (item.Text == contract)
                {
                    item.Click();
                }
            }
        }

        public string GetPageTitle()
        {
            return _pageTitel.WaitForElementIfVisible().Text;
        }
    }
}
