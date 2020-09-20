using System;
using AppiumPractice01.WindowsCalculatorPageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppiumPractice01.Tests
{
    [TestClass]
    public class Appium02
    {
        [TestMethod]
        public void Standard_AddTwoNumbers()
        {
            // Given I open the Calculator application
            Driver.StartApp();
            // And I navigate to the Standard calculator
            StandardPage.GoTo();
            // When I add 77 and 11
            StandardPage.AddNumbers(new int[] { 77, 11 });
            // Then the result displayed is 88
            Assert.IsTrue(StandardPage.VerifyResultDisplayedIs(88));
            // And I clean up the Calculator test
            Driver.Shutdown();
        }

        [TestMethod]
        public void Scientific_SquareNumber()
        {
            Driver.StartApp();
            ScientificPage.GoTo();
            ScientificPage.Square(4);
            Assert.IsTrue(ScientificPage.VerifyResultDisplayedIs(16));
            Driver.Shutdown();
        }

        [TestMethod]
        public void Scientific_GetAnAttribute_01()
        {
            Driver.StartApp();
            ScientificPage.GoTo();
            Assert.IsFalse(ScientificPage.VerifyReciprocalHasKeyboardFocus());
            Driver.Shutdown();
        }

        [TestMethod]
        public void Scientific_GetAnAttribute_02()
        {
            Driver.StartApp();
            ScientificPage.GoTo();
            Assert.IsTrue(ScientificPage.VerifyReciprocalDoesNotHaveKeyboardFocus());
            Driver.Shutdown();
        }
    }
}
