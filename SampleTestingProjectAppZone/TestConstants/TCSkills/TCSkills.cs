using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SampleTestingProjectAppZone.TestBase;
using SampleTestingProjectAppZone.TestReusables.ReusableObjects;
using SampleTestingProjectAppZone.TestConstants.TCHome;
using SampleTestingProjectAppZone.Properties;

namespace SampleTestingProjectAppZone.TestConstants.TCSkills
{
    [TestClass]
    public class TCSkills
    {
        
        //These are the controls used on the user interface.
        public static String TestAdminMenu = Settings.Default.AdminMenu;
        public static String TestQualificationMenu = Settings.Default.QualificationMenu;
        public static String TestSkillsMenu = Settings.Default.SkillsMenu;
        public static String TestAddButton = Settings.Default.BtnAddSkill;
        public static String TestSkillTitle = Settings.Default.SkillTitle;
        public static String TestSkillDescription = Settings.Default.SkillDescription;
    }
}
