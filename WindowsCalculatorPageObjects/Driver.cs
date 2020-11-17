using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;

namespace AppiumPractice01.WindowsCalculatorPageObjects
{
    public static class Driver
    {
        public static WindowsDriver<WindowsElement> driver;

        public static void StartApp()
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
            driver = new WindowsDriver<WindowsElement>(appiumLocalServer, cap);
        }

        public static WindowsDriver<WindowsElement> Instance()
        {
            return driver;
        }

        public static void Shutdown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
