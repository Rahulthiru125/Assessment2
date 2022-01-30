using Assessment2.loginPageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assessment2.Test
{
    [TestClass]
    public class TestingMethod
    {
        [TestMethod]
        public void LaunchLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            AmazonLogin l = new AmazonLogin(driver);
            l.LoginPage();
            l.EnterUserDetails();
            l.EnterPassword();
            Thread.Sleep(6000);
            driver.Close();
        }
        /*
        [TestMethod]
        public void LaunchLoginT1()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            AmazonLogin l1 = new AmazonLogin(driver);
            l1.LoginPage();
            l1.EnterUserDetailsT1();
            l1.EnterPasswordT1();
            Thread.Sleep(6000);
            driver.Close();
        }
        */
    }
}
