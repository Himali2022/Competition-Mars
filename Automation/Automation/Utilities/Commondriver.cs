using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Pages;

namespace Automation.Utilities
{
    public class Commondriver
    {
        public IWebDriver driver;

        public void SignInSteps()
        {
            driver = new ChromeDriver();

            //login page object initialization and definition
            SignInPage SignInPageObj = new SignInPage();
            SignInPageObj.LoginAction();
        }

               public void CloseTestRun()
        {
            driver.Close();
        }
    }
}
