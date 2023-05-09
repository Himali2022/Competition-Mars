using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Utilities;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Automation.Pages
{
    public class SignInPage:Commondriver
    {
        public void LoginAction()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //launch Mars page
            driver.Navigate().GoToUrl("http://localhost:5000/Home");



            #region
            Wait.WaitForElementToBeClickable(driver, "XPath","//a[@class='item']", 50);

            IWebElement signinButton = driver.FindElement(By.XPath("//a[@class='item']"));

            Wait.WaitForElementToBeClickable(driver, "XPath", "//input[@name='email']", 50);

            IWebElement emailTextbox = driver.FindElement(By.XPath("//input[@name='email']"));

            Wait.WaitForElementToBeClickable(driver, "XPath", "//input[@type='password']", 50);

            IWebElement passwordTextbox = driver.FindElement(By.XPath("//input[@type='password']"));

            Wait.WaitForElementToBeClickable(driver, "XPath", "//button[@class='fluid ui teal button']", 50);

            IWebElement loginButton = driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
            #endregion

            // click on sign in button       
            signinButton.Click();

            // identify emailtextbox and enter email address             
            emailTextbox.SendKeys("himalipranasinghe@gmail.com");
                  
            // identify passwordtextbox and enter password            
            passwordTextbox.SendKeys("InternHimo22");

            // click on login button
            loginButton.Click();
            

        }
        public void CloseDriver()
        {
            driver.Close();
        }
    }

}

