using System;
using System.Linq;

namespace UITests.Terminal.PageObjects
{
    public class SelectPersonPage
    {
        private CustomFindBy _backButton = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.BackButton);
        private CustomFindBy _peopleList = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.PeopleList);

        private CustomFindBy _numZero = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumZero);
        private CustomFindBy _numOne = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumOne);
        private CustomFindBy _numTwo = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumTwo);
        private CustomFindBy _numThree = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumThree);
        private CustomFindBy _numFour = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumFour);
        private CustomFindBy _numFive = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumFive);
        private CustomFindBy _numSix = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumSix);
        private CustomFindBy _numSeven = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumSeven);
        private CustomFindBy _numEight = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumEight);
        private CustomFindBy _numNine = new CustomFindBy(How.AccessibilityId, AutomationLocators.SelectPersonPage.NumNine);

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

                switch (digit)
                {
                    case 0:
                        _numZero.WaitForElementToBeClickable().Click();
                        break;
                    case 1:
                        _numOne.WaitForElementToBeClickable().Click();
                        break;
                    case 2:
                        _numTwo.WaitForElementToBeClickable().Click();
                        break;
                    case 3:
                        _numThree.WaitForElementToBeClickable().Click();
                        break;
                    case 4:
                        _numFour.WaitForElementToBeClickable().Click();
                        break;
                    case 5:
                        _numFive.WaitForElementToBeClickable().Click();
                        break;
                    case 6:
                        _numSix.WaitForElementToBeClickable().Click();
                        break;
                    case 7:
                        _numSeven.WaitForElementToBeClickable().Click();
                        break;
                    case 8:
                        _numEight.WaitForElementToBeClickable().Click();
                        break;
                    case 9:
                        _numNine.WaitForElementToBeClickable().Click();
                        break;
                }
            } while (numOrder > 1);
        }

        public void ClickToBackButton()
        {
            _backButton.WaitForElementToBeClickable().Click();
        }
    }
}
