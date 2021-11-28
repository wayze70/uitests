using OpenQA.Selenium;
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

    public class CustomFindBy
    {
        private const int Timeout = 30;
        private WebDriverWait Wait => new WebDriverWait(Session.Driver, TimeSpan.FromSeconds(Timeout));

        private How _by;
        private string _value;

        public CustomFindBy(How by, string value)
        {
            _by = by;
            _value = value;
        }

        public WindowsElement GetElement()
        {
            var elements = GetElements();

            if (elements != null)
            {
                if (elements.Count > 0)
                {
                    return elements.ElementAt(0);
                }
            }

            return null;
        }

        public IReadOnlyCollection<WindowsElement> GetElements()
        {
            try
            {
                return _by switch
                {
                    How.AccessibilityId => Session.Driver.FindElementsByAccessibilityId(_value),
                    How.Name => Session.Driver.FindElementsByName(_value),
                    How.ClassName => Session.Driver.FindElementsByClassName(_value),
                    How.XPath => Session.Driver.FindElementsByXPath(_value),
                    _ => null,
                };
            }
            catch (WebDriverException)
            {
                return null;
            }
        }

        public WindowsElement WaitForElement()
        {
            return Wait.Until(driver => { return GetElement(); });
        }

        public IReadOnlyCollection<WindowsElement> WaitForElements()
        {
            return Wait.Until(driver => {
                var elements = GetElements();

                if (elements != null)
                {
                    if (elements.Count > 0)
                    {
                        return elements;
                    }
                }

                return null;
            });
        }

        public WindowsElement WaitForElementToBeClickable()
        {
            return Wait.Until(driver => {
                try
                {
                    var element = WaitForElementIfVisible();
                    if (element != null && element.Enabled)
                    {
                        return element;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch
                {
                    return null;
                }
            });
        }

        public WindowsElement WaitForElementIfVisible()
        {
            return Wait.Until(driver => {
                try
                {
                    var element = GetElement();
                    return element.Displayed ? element : null;
                }
                catch
                {
                    return null;
                }
            });
        }
    }
}
