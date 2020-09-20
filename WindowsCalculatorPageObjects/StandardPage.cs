using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumPractice01.WindowsCalculatorPageObjects
{
    public class StandardPage
    {
        protected static readonly By PLUS_BUTTON = MobileBy.AccessibilityId("plusButton");
        protected static readonly By DISPLAY_RESULT = MobileBy.AccessibilityId("CalculatorResults");

        public static void GoTo()
        {
            NavigationPage.GoToStandardPage();
        }

        public static void AddNumbers(int[] numbers)
        {
            Driver.Instance().FindElement(DISPLAY_RESULT).Clear();
            IEnumerable<int> numberList = new List<int>(numbers);
            foreach (var number in numberList)
            {
                Driver.Instance().FindElement(DISPLAY_RESULT).SendKeys(number.ToString());
                Driver.Instance().FindElement(PLUS_BUTTON).Click();
            }
        }

        public static bool VerifyResultDisplayedIs(int value)
        {
            try
            {
                bool result = (Int32.Parse(Driver.Instance().FindElement(DISPLAY_RESULT).GetAttribute("Name").Replace("Display is ", ""))) == value ? true : false;
                if (result)
                    return true;
                else
                    return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
