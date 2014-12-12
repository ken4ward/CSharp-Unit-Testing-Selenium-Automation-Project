using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using SampleTestingProjectAppZone.TestReusables.ReusableObjects;
using SampleTestingProjectAppZone.TestUtils.TestThreads;
using SampleTestingProjectAppZone.TestConstants.TCHome;
using SampleTestingProjectAppZone.TestClass.Home;
using SampleTestingProjectAppZone.TestClass.Skills;
using SampleTestingProjectAppZone.TestBase;
using SampleTestingProjectAppZone.TestConstants.TCSkills;

namespace SampleTestingProjectAppZone
{
    [TestClass]
    public class TestRunner
    {
        IWebDriver driver;
        public TestRunner()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(TCHome.URL);
            driver.Manage().Window.Maximize();
            TimingSettings.WaitTime();
        }

        [TestMethod]
        public void RunningTestCases() 
        {
            //Login test
            TestHome testHome = new TestHome(driver);
            testHome.LoginSuccessful();
            //Logout test
            TestBase.TestBase testBase = new TestBase.TestBase(driver);
            TimingSettings.WaitTime();
            testBase.logOut();
            //Navigating to the test skill page
            TestSkills testSkills = new TestSkills(driver);
            testSkills.NavigateToSkillsPage();
            TimingSettings.WaitTime();
            testSkills.CreateNewSkill(testSkills.AddRandomTitle(), null);
            testBase.logOut();
            //Creating a skill
           
        }    
    }
}
