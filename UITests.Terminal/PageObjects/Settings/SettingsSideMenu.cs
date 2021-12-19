using System.Linq;

namespace UITests.Terminal.PageObjects.Settings
{
    public class SettingsSideMenu
    {
        private CustomFindBy _backButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.SettingSideBar.BackButton);

        private CustomFindBy _sideBarMenuItems = new CustomFindBy(How.ClassName, AutomationLocators.Settings.SettingSideBar.SideMenuItems);

        private CustomFindBy _pageTitle = new CustomFindBy(How.XPath, AutomationLocators.Settings.SettingSideBar.PageTitle);

        private CustomFindBy _accountListItem = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.SettingSideBar.AccountListItem);
        private CustomFindBy _locationListItem = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.SettingSideBar.LocationListItem);
        private CustomFindBy _behaviorListItem = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.SettingSideBar.BehaviorListItem);
        private CustomFindBy _appearanceListItem = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.SettingSideBar.AppearanceListItem);
        private CustomFindBy _generalListItem = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.SettingSideBar.GeneralListItem);
        private CustomFindBy _peopleListItem = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.SettingSideBar.PeopleListItem);
        private CustomFindBy _identificationSettingListItem = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.SettingSideBar.IdentificationSettingListItem);

        public void ClickToSideMenuItem(string listItemName)
        {
            for (int i = 0; i < _sideBarMenuItems.WaitForElements().Count; i++)
            {
                var elementText = new CustomFindBy(How.XPath, $"//List[@AutomationId='MenuListView']/ListItem[@ClassName='ListViewItem'][@Name='Logeto.Client.UWP.Terminal.Utils.MenuItem'][position()={i + 1}]/Text[@ClassName='TextBlock'][position()=1]").WaitForElementToBeClickable();

                if (elementText.Text == listItemName)
                {
                    elementText.Click();
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

        /*public void ClickToAccountListItem()
        {
            _accountListItem.WaitForElementToBeClickable().Click();
        }

        public void ClickToLocationListItem()
        {
            _locationListItem.WaitForElementToBeClickable().Click();
        }

        public void ClickToBehaviorListItem()
        {
            _behaviorListItem.WaitForElementToBeClickable().Click();
        }

        public void ClickToAppearanceListItem()
        {
            _appearanceListItem.WaitForElementToBeClickable().Click();
        }

        public void ClickToGeneralListItem()
        {
            _generalListItem.WaitForElementToBeClickable().Click();
        }

        public void ClickToPeopleListItem()
        {
            _peopleListItem.WaitForElementToBeClickable().Click();
        }

        public void ClickToIdentificationSettingListItem()
        {
            _identificationSettingListItem.WaitForElementToBeClickable().Click();
        }*/
    }
}
