using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;

namespace AppiumPractice01.Extensions
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Use this when you want to wait for an element. The first TimeSpan is the max time you want to wait for the element to appear. The second TimeSpan is how often to check for the element.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <param name="timeout"></param>
        /// <param name="pollingInterval"></param>
        /// <returns>If found, the element is returned.</returns>
        public static WindowsElement FindElement(this WindowsDriver<WindowsElement> driver, By by, TimeSpan timeout, TimeSpan pollingInterval)
        {
            var wait = new DefaultWait<WindowsDriver<WindowsElement>>(driver);
            wait.Timeout = timeout;
            wait.PollingInterval = pollingInterval;
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait.Until(x => { return x.FindElement(by); });
        }
    }
}
