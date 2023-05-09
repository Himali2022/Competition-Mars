using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Utilities;

namespace Automation.Utilities
{
    public class Wait:Commondriver
    {
        public static void WaitForElementToBeClickable(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 50));
        }

      
            

    }

}
