using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SampleTestingProjectAppZone.TestConstants.TCHome;

namespace SampleTestingProjectAppZone.TestReusables.ReusableObjects
{
    [TestClass]
    public class Reusables : TestBase.TestBase
    {
        public Reusables() { }
        public Reusables(IWebDriver driver) : base(driver) { }

        
        public void Login(String username, String password)
        {
            driver.FindElement(By.Id(TCHome.username)).Clear();
            driver.FindElement(By.Id(TCHome.username)).SendKeys(username);
            driver.FindElement(By.Id(TCHome.password)).Clear();
            driver.FindElement(By.Id(TCHome.password)).SendKeys(password);
            driver.FindElement(By.Id(TCHome.LoginButton)).Click();
        }
    }
}
