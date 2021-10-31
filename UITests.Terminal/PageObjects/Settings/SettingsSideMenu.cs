namespace UITests.Terminal.PageObjects.Settings
{
    public class SettingsSideMenu
    {
        private CustomFindBy _backButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.Settings.SettingSideBar.BackButton);

        private CustomFindBy _accountListItem = new CustomFindBy(How.Name, AutomationLocators.Settings.SettingSideBar.AccountListItem);
        private CustomFindBy _locationListItem = new CustomFindBy(How.Name, AutomationLocators.Settings.SettingSideBar.LocationListItem);
        private CustomFindBy _behaviorListItem = new CustomFindBy(How.Name, AutomationLocators.Settings.SettingSideBar.BehaviorListItem);
        private CustomFindBy _appearanceListItem = new CustomFindBy(How.Name, AutomationLocators.Settings.SettingSideBar.AppearanceListItem);
        private CustomFindBy _generalListItem = new CustomFindBy(How.Name, AutomationLocators.Settings.SettingSideBar.GeneralListItem);
        private CustomFindBy _peopleListItem = new CustomFindBy(How.Name, AutomationLocators.Settings.SettingSideBar.PeopleListItem);
        private CustomFindBy _identificationSettingListItem = new CustomFindBy(How.Name, AutomationLocators.Settings.SettingSideBar.IdentificationSettingListItem);

        public void ClickToBackButton()
        {
            _backButton.WaitForElementToBeClickable().Click();
        }

        public void ClickToAccountListItem()
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
        }
    }
}
