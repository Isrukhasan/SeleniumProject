using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using UnitTestProject1.Pages;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 : DriverHelper
    {
        
        
        public void LoginTest()
        {
            ChromeOptions option = new ChromeOptions();
            Driver = new ChromeDriver(option);
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void PolicyTest()
        {
            PolicyPage policyPage = new PolicyPage();
          
            ChromeOptions option = new ChromeOptions();
            Driver = new ChromeDriver(option);
            Driver.Navigate().GoToUrl("https://www.telerik.com/kendo-angular-ui/components/dropdowns/examples/overview/?theme=default-ocean-blue&themeVersion=5.8.0");
            Thread.Sleep(20000);

            policyPage.ClickDropDownValueCombined();
            //policyPage.ClickDropDown();
            
            //policyPage.ClickDropDownValue();
            Thread.Sleep(3000);
            Driver.Quit();
        }
    }
}


        //public void HomePageTest()
        //{
        //    HomePage homePage = new HomePage();
        //    IWebDriver Driver = new ChromeDriver();
            

        //    Driver.Navigate().GoToUrl("https://www.telerik.com/kendo-angular-ui/components/dropdowns/examples/overview/?theme=default-ocean-blue&themeVersion=5.8.0");
        //    Thread.Sleep(3000);
        //    homePage.ClickMyDropDown();
            
        //    Assert.IsTrue(true, "buttonClicked");

        //    Driver.Quit();
        //}

       // [TestMethod]
        //public void T1()
        //{
           
        //    Driver.Navigate().GoToUrl("https://www.telerik.com/kendo-angular-ui/components/dropdowns/examples/overview/?theme=default-ocean-blue&themeVersion=5.8.0");

        //    //CustomControl.EnterText(Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Mango");

        //    Thread.Sleep(7000);
        //    CustomControl.Click(Driver.FindElement(By.XPath("/html/body/div/div[1]/my-app/div/div[4]/kendo-label/kendo-dropdowntree/span[1]")));
            
        //    CustomControl.Click(Driver.FindElement(By.XPath("/html/body/div/div[1]/my-app/kendo-popup/div/kendo-treeview/ul/li[2]/ul/li[1]/div/span/span")));
        //    Thread.Sleep(7000);

        //    Driver.Quit();

        //}
    

