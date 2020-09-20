using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumPractice01.WindowsCalculatorPageObjects
{
    public static class NavigationPage
    {
        private static readonly By ACCORDIAN = MobileBy.AccessibilityId("TogglePaneButton");
        private static readonly By STANDARD = MobileBy.AccessibilityId("Standard");
        private static readonly By SCIENTIFIC = MobileBy.AccessibilityId("Scientific");

        public static void GoToStandardPage()
        {
            Driver.Instance().FindElement(ACCORDIAN).Click();
            Driver.Instance().FindElement(STANDARD).Click();
        }

        public static void GoToScientificPage()
        {
            Driver.Instance().FindElement(ACCORDIAN).Click();
            Driver.Instance().FindElement(SCIENTIFIC).Click();
        }
    }
}
