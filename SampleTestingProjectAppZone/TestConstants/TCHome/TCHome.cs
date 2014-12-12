using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SampleTestingProjectAppZone.Properties;

namespace SampleTestingProjectAppZone.TestConstants.TCHome
{
    [TestClass]
    class TCHome
    {
        public static String URL = Settings.Default.URL;
        public static String username = Settings.Default.LoginUsernameTextbox;
        public static String password = Settings.Default.LoginPasswordTextbox;
        public static String LoginButton = Settings.Default.LoginButton;
        public static String TestAdmin = "Admin";
        public static String TestPassword = "admin";
        public static String TestWrongUser = "username";
        public static String TestWrongPassword = "password";
        public static String TestEmpty = "";   
    }
}