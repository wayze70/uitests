namespace UITests.Terminal.PageObjects.FillRecordPages
{
    public class ListCustomFieldPage : CommonItems
    {
        private FindBy _pageTitle = new FindBy(How.XPath, AutomationLocators.FillRecordPages.ListCustomFieldPage.PageTitle);
        private FindBy _listCustomList = new FindBy(How.ClassName, AutomationLocators.FillRecordPages.ListCustomFieldPage.ListCustomList);

        public void SelectListCustomFieldItem(string item)
        {
            foreach (var listItem in _listCustomList.WaitForElements())
            {
                if (listItem.Text == item)
                {
                    listItem.Click();
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
