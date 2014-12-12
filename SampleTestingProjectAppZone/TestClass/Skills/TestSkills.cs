using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SampleTestingProjectAppZone.TestBase;
using SampleTestingProjectAppZone.TestReusables.ReusableObjects;
using SampleTestingProjectAppZone.TestConstants.TCHome;
using SampleTestingProjectAppZone.TestConstants.TCSkills;
using SampleTestingProjectAppZone.TestClass.Home;

namespace SampleTestingProjectAppZone.TestClass.Skills
{
    [TestClass]
    public class TestSkills : TestBase.TestBase
    {
        public TestSkills(IWebDriver driver) : base(driver) { }

        public TestSkills() { }
        
        //Steps to create a new skill
        public void NavigateToSkillsPage() 
        {
            //1. Login into the account
            Reusables reusables = new Reusables(driver);
            reusables.Login(TCHome.TestAdmin, TCHome.TestPassword);
            //2. Click on admin link
            driver.FindElement(By.Id(TCSkills.TestAdminMenu)).Click();
            //3. Click on Qualification
            driver.FindElement(By.Id(TCSkills.TestQualificationMenu)).Click();
            //4. Click on Skills and assert that skill is the label on the page
            driver.FindElement(By.Id(TCSkills.TestSkillsMenu)).Click();
            //5. Click on "Add" button to create a new Skill
            driver.FindElement(By.Id(TCSkills.TestAddButton)).Click();
        }

        public void CreateNewSkill(String SkillTitle, String SkillDescription) 
        {
            //Clear the title textbox
            driver.FindElement(By.Id(TCSkills.TestSkillTitle)).Clear();
            //Add data into the title box
            driver.FindElement(By.Id(TCSkills.TestSkillTitle)).SendKeys(SkillTitle);
            driver.FindElement(By.Id("")).Clear();
            driver.FindElement(By.Id(TCSkills.TestSkillDescription)).SendKeys(SkillDescription);
        }

        public Random random;
        public int RandomlyCreatedData;
        public String CustomTitle;

        public String AddRandomTitle()
        {
            //RandomlyCreatedData = random.Next(100);
            CustomTitle = "AppZone";// + RandomlyCreatedData.ToString();
            return CustomTitle;
        }
    }
}
