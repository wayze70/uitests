using System.Linq;

namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class ContractPage : CommonItems
    {
        private FindBy _pageTitel = new FindBy(How.XPath, AutomationLocators.FillRecordPages.ContractPage.PageTitel);
        private FindBy _contractList = new FindBy(How.ClassName, AutomationLocators.FillRecordPages.ContractPage.ContractList);

        public void SelectContract(string contractName)
        {
            foreach (var item in _contractList.WaitForElements())
            {
                if (item.Text == contractName)
                {
                    item.Click();
                    break;
                }
            }
        }

        public bool IsContractSelected()
        {
            return !_contractList.WaitForElements().ElementAt(0).Selected;
        }

        public string GetPageTitle()
        {
            return _pageTitel.WaitForElementIfVisible().Text;
        }
    }
}
