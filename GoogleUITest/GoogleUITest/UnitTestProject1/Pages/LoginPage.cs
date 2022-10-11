using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestProject1;

namespace UnitTestProject1.Pages
{
    public class LoginPage: DriverHelper
    {
        

        public LoginPage()
        {
        }

        IWebElement txtUserName => DriverHelper.Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => DriverHelper.Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => DriverHelper.Driver.FindElement(By.CssSelector(".btn-default"));


        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
