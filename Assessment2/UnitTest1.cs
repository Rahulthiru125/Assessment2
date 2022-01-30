using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Assessment2
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            
            driver.FindElement(By.XPath("//a[@data-nav-role='signin' and @data-csa-c-type='link']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@id='ap_email']")).SendKeys("rahulthiru125@gmail.com"+Keys.Enter);
            driver.FindElement(By.XPath("//input[@id='ap_password']"));
            //Assert.AreEqual("Google", expected);
        }
        
        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//a[@data-nav-role='signin' and @data-csa-c-type='link']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@id='ap_email']")).SendKeys("rahulthiru125" + Keys.Enter);
            driver.FindElement(By.XPath("//input[@id='ap_password']"));
        }
        [TearDown]
        public void ExitBrowser()
        {
            Thread.Sleep(6000);
            driver.Quit();
        }
    }
}