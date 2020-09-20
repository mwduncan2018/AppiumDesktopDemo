using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumPractice01.WindowsCalculatorPageObjects
{
    public class ScientificPage : StandardPage
    {
        protected static readonly By SQUARE = MobileBy.AccessibilityId("xpower2Button");
        protected static readonly By RECIPROCAL = MobileBy.AccessibilityId("invertButton");

        public static new void GoTo()
        {
            NavigationPage.GoToScientificPage();
        }

        public static void Square(int number)
        {
            Driver.Instance().FindElement(DISPLAY_RESULT).Clear();
            Driver.Instance().FindElement(DISPLAY_RESULT).SendKeys(number.ToString());
            Driver.Instance().FindElement(SQUARE).Click();
        }

        public static bool VerifyReciprocalHasKeyboardFocus()
        {
            return Driver.Instance().FindElement(RECIPROCAL).GetAttribute("HasKeyboardFocus").Equals("True");
        }

        public static bool VerifyReciprocalDoesNotHaveKeyboardFocus()
        {
            return Driver.Instance().FindElement(RECIPROCAL).GetAttribute("HasKeyboardFocus").Equals("False");
        }

    }
}
