using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SampleTestingProjectAppZone.TestBase
{
    [TestClass]
    public class TestBase
    {
       public IWebDriver driver;

        public TestBase(){}

        public TestBase(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public void logOut() 
        {
            //1. After login click on "Welcome Admin" link
            driver.FindElement(By.Id("welcome")).Click();
            //2. click on "Logout" link
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
