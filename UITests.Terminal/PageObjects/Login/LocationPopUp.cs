namespace UITests.Terminal.PageObjects.Login
{
    public class LocationPopUp
    {
        private CustomFindBy _map = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.LocationPopUp.Map);
        private CustomFindBy _select = new CustomFindBy(How.AccessibilityId, AutomationLocators.Login.LocationPopUp.SelectButton);

        public void SelectLocationFromMap()
        {
            _map.WaitForElementToBeClickable().Click();
            _select.WaitForElementToBeClickable().Click();
        }
    }
}
