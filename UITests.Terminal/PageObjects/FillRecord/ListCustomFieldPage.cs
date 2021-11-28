namespace UITests.Terminal.PageObjects.FillRecord
{
    public class ListCustomFieldPage : CommonItems
    {
        private CustomFindBy _pageTitle = new CustomFindBy(How.XPath, AutomationLocators.FillRecord.ListCustomFieldPage.PageTitle);
        private CustomFindBy _listCustomList = new CustomFindBy(How.ClassName, AutomationLocators.FillRecord.ListCustomFieldPage.ListCustomList);

        public void SelectListItem(string item)
        {
            foreach (var listItem in _listCustomList.WaitForElements())
            {
                if (listItem.Text == item)
                {
                    listItem.Click();
                }
            }
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }
    }
}
