namespace UITests.Terminal.PageObjects.CommonPages
{
    public class LocationPopupPage
    {
        private FindBy _map = new FindBy(How.AccessibilityId, AutomationLocators.CommonPages.LocationPopUpPage.Map);
        private FindBy _select = new FindBy(How.AccessibilityId, AutomationLocators.CommonPages.LocationPopUpPage.SelectButton);

        public void SelectLocationFromMap()
        {
            _map.WaitForElementToBeClickable().Click();
            _select.WaitForElementToBeClickable().Click();
        }
    }
}
