using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2.loginPageObject
{
    public class AmazonLogin
    {
        IWebDriver driver;
        By SignIn = By.XPath("//a[@data-nav-role='signin' and @data-csa-c-type='link']");
        By UserName = By.XPath("//input[@id='ap_email']");
        By Password = By.XPath("//input[@id='ap_password']");

        public  AmazonLogin(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginPage()
        {
            driver.FindElement(SignIn).Click();   
        }

        public void EnterUserDetails()
        {
            driver.FindElement(UserName).SendKeys("rahulthiru125@gmail.com"+Keys.Enter);
        }
        public void EnterPassword()
        {
            driver.FindElement(Password).SendKeys("12345"+Keys.Enter);
        }
        public void EnterUserDetailsT1()
        {
            driver.FindElement(UserName1).SendKeys("rahulthiru125" + Keys.Enter);
        }

    }
}
