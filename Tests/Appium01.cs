using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;

namespace AppiumPractice01
{
    [TestClass]
    public class Appium01
    {
        [TestMethod]
        [Ignore]
        public void TestFindElement()
        {
            var appId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
            var platformName = "Windows";
            var deviceName = "WindowsPC";
            var cap = new AppiumOptions();
            cap.AddAdditionalCapability(MobileCapabilityType.App, appId);
            cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, platformName);
            cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, deviceName);
            var appiumLocalServer = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            appiumLocalServer.Start();
            var driver = new WindowsDriver<WindowsElement>(appiumLocalServer, cap);

            var btn7 = MobileBy.AccessibilityId("num7Button");
            var btn1 = MobileBy.AccessibilityId("num1Button");
            var btnEquals = MobileBy.AccessibilityId("equalButton");
            var btnPlus = MobileBy.AccessibilityId("plusButton");

            driver.FindElement(btn7).Click();
            driver.FindElement(btn7).Click();
            driver.FindElement(btnPlus).Click();
            driver.FindElement(btn1).Click();
            driver.FindElement(btn1).Click();
            driver.FindElement(btnEquals).Click();

            driver.Close();
            driver.Dispose();
        }

        [TestMethod]
        [Ignore]
        public void StartWithAppiumLocalServer()
        {
            var appId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
            var platformName = "Windows";
            var deviceName = "WindowsPC";

            var cap = new AppiumOptions();
            cap.AddAdditionalCapability(MobileCapabilityType.App, appId);
            cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, platformName);
            cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, deviceName);

            var appiumLocalServer = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            appiumLocalServer.Start();

            var driver = new WindowsDriver<WindowsElement>(appiumLocalServer, cap);
            Thread.Sleep(3000);
            driver.Close();
            driver.Dispose();
        }

        [TestMethod]
        [Ignore]
        public void StartWinCalc()
        {
            var appId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
            var platformName = "Windows";
            var deviceName = "WindowsPC";
            var uniformResourceId = new Uri("http://127.0.0.1:4723/wd/hub");

            var cap = new AppiumOptions();
            cap.AddAdditionalCapability(MobileCapabilityType.App, appId);
            cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, platformName);
            cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, deviceName);

            var driver = new WindowsDriver<WindowsElement>(uniformResourceId, cap);
            Thread.Sleep(3000);
            driver.Close();
            driver.Dispose();
        }

    }
}
