using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SampleTestingProjectAppZone.TestBase;
using SampleTestingProjectAppZone.TestReusables.ReusableObjects;
using SampleTestingProjectAppZone.TestConstants.TCHome;

namespace SampleTestingProjectAppZone.TestClass.Home
{
    [TestClass]
    public class TestHome : TestBase.TestBase
    {
        public TestHome(IWebDriver driver) : base(driver) { }

        public TestHome(){ }

        public void LoginSuccessful() 
        {
            Reusables reusables = new Reusables(driver);
            reusables.Login(TCHome.TestWrongUser, TCHome.TestPassword);
            reusables.Login(TCHome.TestAdmin, TCHome.TestWrongPassword);
            reusables.Login(TCHome.TestAdmin, TCHome.TestEmpty);
            reusables.Login(TCHome.TestEmpty, TCHome.TestPassword);
            reusables.Login(TCHome.TestEmpty, TCHome.TestEmpty);
            reusables.Login(TCHome.TestAdmin, TCHome.TestPassword);
        }
    }
}
