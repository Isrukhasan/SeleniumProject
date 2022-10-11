using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnitTestProject1;

namespace UnitTestProject1.Pages
{
    public class PolicyPage : DriverHelper
    {
       

        public PolicyPage()
        {
            
        }

        public PolicyPage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        IWebElement dropDownElement => DriverHelper.Driver.FindElement(By.XPath("/html/body/div/div[1]/my-app/div/div[4]/kendo-label/kendo-dropdowntree/span[1]"));
        IWebElement dropDownElementValue => DriverHelper.Driver.FindElement(By.XPath("/html/body/div/div[1]/my-app/kendo-popup/div/kendo-treeview/ul/li[2]/ul/li[1]/div/span/span"));

        public void ClickDropDownValueCombined()
        {
            dropDownElement.Click();
            Thread.Sleep(3000);
            dropDownElementValue.Click();
        }
        public void ClickDropDown() => dropDownElement.Click();
        public void ClickDropDownValue() => dropDownElementValue.Click();
        
    }
}