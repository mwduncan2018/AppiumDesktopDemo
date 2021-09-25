using AppiumPractice01.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;

namespace AppiumPractice01.WindowsCalculatorPageObjects
{
    public class StandardPage : AbstractPage
    {
        protected static readonly By PLUS_BUTTON = MobileBy.AccessibilityId("plusButton");
        protected static readonly By DISPLAY_RESULT = MobileBy.AccessibilityId("CalculatorResults");

        public static void GoTo()
        {
            NavigationPage.GoToStandardPage();
        }

        public static void AddNumbers(int[] numbers)
        {
            Driver.Instance().FindElement(DISPLAY_RESULT, 
                TimeSpan.FromSeconds(1), TimeSpan.FromMilliseconds(500)).Clear();
            IEnumerable<int> numberList = new List<int>(numbers);
            foreach (var number in numberList)
            {
                Driver.Instance().FindElement(DISPLAY_RESULT, TimeSpan.FromSeconds(1), 
                    TimeSpan.FromMilliseconds(500)).SendKeys(number.ToString());
                Driver.Instance().FindElement(PLUS_BUTTON, TimeSpan.FromSeconds(1), 
                    TimeSpan.FromMilliseconds(500)).Click();
            }
        }

        public static bool VerifyResultDisplayedIs(int value)
        {
            try
            {
                return (Int32.Parse(Driver.Instance().FindElement(DISPLAY_RESULT)
                    .GetAttribute("Name").Replace("Display is ", ""))) == value;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
