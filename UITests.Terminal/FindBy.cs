using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UITests.Terminal
{
    public enum How
    {
        AccessibilityId,
        Name,
        ClassName,
        XPath
    }

    public class FindBy
    {
        private const int Timeout = 30;
        private WebDriverWait _wait => new WebDriverWait(Session.Driver, TimeSpan.FromSeconds(Timeout));

        private How _by;
        private string _value;

        public FindBy(How by, string value)
        {
            _by = by;
            _value = value;
        }

        public WindowsElement GetElement()
        {
            return GetElements()?.FirstOrDefault();
        }

        public IReadOnlyCollection<WindowsElement> GetElements()
        {
            IReadOnlyCollection<WindowsElement> result;

            result = _by switch
            {
                How.AccessibilityId => Session.Driver.FindElementsByAccessibilityId(_value),
                How.Name => Session.Driver.FindElementsByName(_value),
                How.ClassName => Session.Driver.FindElementsByClassName(_value),
                How.XPath => Session.Driver.FindElementsByXPath(_value),
                _ => null,
            };

            return (result?.Any() == true) ? result : null;
        }

        public WindowsElement WaitForElement()
        {
            WebDriverWait _wait = new WebDriverWait(Session.Driver, TimeSpan.FromSeconds(Timeout));

            return _wait.Until(driver => GetElement());
        }

        public IReadOnlyCollection<WindowsElement> WaitForElements()
        {
            return _wait.Until(driver =>
            {
                var elements = GetElements();

                return (elements?.Count > 0) ? elements : null;
            });
        }

        public WindowsElement WaitForElementIfVisible()
        {
            return _wait.Until(driver =>
            {
                var element = GetElement();

                return (element?.Displayed == true) ? element : null;
            });
        }

        public IReadOnlyCollection<WindowsElement> WaitForElementsIfVisible()
        {
            return _wait.Until(driver =>
            {
                var elements = GetElements();

                if (elements != null)
                {
                    foreach (var item in elements)
                    {
                        if (item == null || !item.Displayed) // All items in collection must be Displayed
                        {
                            return null;
                        }
                    }

                    return elements;
                }

                return null;
            });
        }

        public WindowsElement WaitForElementToBeClickable()
        {
            return _wait.Until(driver =>
            {
                var element = WaitForElementIfVisible();

                return (element?.Enabled == true) ? element : null;
            });
        }

        public IReadOnlyCollection<WindowsElement> WaitForElementsToBeClickable()
        {
            return _wait.Until(driver =>
            {
                var elements = WaitForElementsIfVisible();

                if (elements != null)
                {
                    foreach (var item in elements)
                    {
                        if (item == null || !item.Enabled) // All items in collection must be Enabled and Displayed
                        {
                            return null;
                        }
                    }

                    return elements;
                }

                return null;
            });
        }
    }
}
