namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class SettingsSideMenu
    {
        private FindBy _backButton = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.SettingsSideMenu.BackButton);


        private FindBy _pageTitle = new FindBy(How.XPath, AutomationLocators.SettingsPages.SettingsSideMenu.PageTitle);

        private FindBy[] _sideMenuItems =
        {
            new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.SettingsSideMenu.AccountListItem),
            new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.SettingsSideMenu.LocationListItem),
            new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.SettingsSideMenu.BehaviorListItem),
            new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.SettingsSideMenu.AppearanceListItem),
            new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.SettingsSideMenu.GeneralListItem),
            new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.SettingsSideMenu.PeopleListItem),
            new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.SettingsSideMenu.IdentificationSettingListItem)
        };

        public void ClickToSideMenuItem(string listItemName)
        {
            foreach (var item in _sideMenuItems)
            {
                if (item.WaitForElement().Text == listItemName)
                {
                    item.WaitForElementToBeClickable().Click();
                    break;
                }
            }
        }

        public string GetPageTitle()
        {
            return _pageTitle.WaitForElementIfVisible().Text;
        }

        public void ClickToBackButton()
        {
            _backButton.WaitForElementToBeClickable().Click();
        }
    }
}
