using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class CustomControl : DriverHelper 
    {
        public static void SendKeys(IWebElement webElement, string value) => webElement.SendKeys(value);
        public static void Click(IWebElement webElement) => webElement.Click();
        public static void DoClick(IWebElement webElement) => webElement.Click();
       
        public static void SelectByValue(IWebElement webElement, string value)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(value);
        }
        public static void SelectByText(IWebElement webElement, string text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);
        }

    }
}
