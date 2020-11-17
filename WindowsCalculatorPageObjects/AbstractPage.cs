using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;

namespace AppiumPractice01.WindowsCalculatorPageObjects
{
    public class AbstractPage
    {
        protected static WindowsElement Wait(By element, TimeSpan waitTime, TimeSpan pollingTime)
        {
            var wait = new DefaultWait<WindowsDriver<WindowsElement>>(Driver.Instance());
            wait.Timeout = waitTime;
            wait.PollingInterval = pollingTime;
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait.Until(x => { return x.FindElement(element);});            
        }
    }
}
