using NUnit.Framework;
using System;
using System.Linq;
using System.Threading;

namespace UITests.Terminal.PageObjects.SettingsPages
{
    public class PeoplePage : SettingsSideMenu
    {
        private FindBy _peopleList = new FindBy(How.Name, AutomationLocators.SettingsPages.PeoplePage.PeopleList);
        private FindBy _pinCheckBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.PeoplePage.PinCheckBox);
        private FindBy _pinTextBox = new FindBy(How.AccessibilityId, AutomationLocators.SettingsPages.PeoplePage.PinTextBox);

        public void ClickToPerson()
        {
            var elements = _peopleList.WaitForElements();
            elements.ElementAt(new Random().Next(0, elements.Count - 1)).Click();
        }

        public void SetPinToAllPeople(string pin)
        {
            for (int i = 0; i < _peopleList.WaitForElements().Count; i++)
            {
                var element = _peopleList.WaitForElements().ElementAt(i);
                element.Click();

                // When the state of the checkbox changes, the people list is refreshed
                if (!GetPinCheckBoxState())
                {
                    SetPinCheckBoxState(true);
                    var elementCheck = _peopleList.WaitForElements().ElementAt(i);

                    for (int u = 0; (element.Id == elementCheck.Id) && (u < 10); u++)
                    {
                        Thread.Sleep(500);
                        elementCheck = _peopleList.WaitForElements().ElementAt(i);
                    }
                }

                SetPin(pin);
                Assert.AreEqual(pin, GetPin());
            }
        }

        public bool GetPinCheckBoxState()
        {
            return _pinCheckBox.WaitForElementIfVisible().Selected;
        }

        public void SetPinCheckBoxState(bool state)
        {
            var element = _pinCheckBox.WaitForElementToBeClickable();

            if (element.Selected == !state)
            {
                element.Click();
            }

            if (element.Selected == !state)
            {
                throw new Exception($"Checkbox was not in correct state");
            }
        }

        public void SetPin(string pin)
        {
            Session.SendKeys(_pinTextBox.WaitForElementToBeClickable(), pin);
        }

        public string GetPin()
        {
            return _pinTextBox.WaitForElementIfVisible().Text;
        }
    }
}
