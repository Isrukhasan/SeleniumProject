using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestProject1;

namespace UnitTestProject1.Pages
{
    public class HomePage : DriverHelper
    {
        public HomePage()
        {
            
        }

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        IWebElement lnkLogin => DriverHelper.Driver.FindElement(By.LinkText("Login"));

        IWebElement lnkLogOff => Driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogOff.Displayed;
    }
}