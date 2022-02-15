using System;
using System.Linq;

namespace UITests.Terminal.PageObjects
{
    public class SelectPersonPage
    {
        private FindBy _backButton = new FindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.BackButton);
        private FindBy _peopleList = new FindBy(How.ClassName, AutomationLocators.SelectPersonPage.PeopleList);

        private FindBy[] _numberVariable = new FindBy[10];

        public SelectPersonPage()
        {
            for (int i = 0; i < _numberVariable.Length; i++)
            {
                _numberVariable[i] = new FindBy(How.AccessibilityId, $"Number{i}Button");
            }
        }

        public void ClickToPerson()
        {
            var elements = _peopleList.WaitForElements();

            elements.ElementAt(new Random().Next(0, elements.Count - 1)).Click();
        }

        public void EnterPin(int pin)
        {
            int digit = 0;
            int numOrder = Convert.ToInt32(Math.Pow(10, pin.ToString().Length));

            do
            {
                pin -= numOrder * digit;
                numOrder /= 10;
                digit = pin / numOrder;

                _numberVariable[digit].WaitForElementToBeClickable().Click();

            } while (numOrder > 1);
        }

        public void WaitForPage()
        {
            _backButton.WaitForElementIfVisible();
            _peopleList.WaitForElements();
        }

        public void ClickToBackButton()
        {
            _backButton.WaitForElementToBeClickable().Click();
        }
    }
}
