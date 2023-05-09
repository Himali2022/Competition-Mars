using Automation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Pages
{
    public class ShareSkillPage:Commondriver
    {
        IWebElement ShareSkillButton => driver.FindElement(By.XPath("//a[@class='ui basic green button']"));
        IWebElement Title => driver.FindElement(By.XPath("//input[@name='title']"));
        IWebElement Description => driver.FindElement(By.XPath("//textarea[@name='description']"));
        IWebElement CategoryDropDown => driver.FindElement(By.XPath("//select[@name='categoryId']"));
        IWebElement SubCategoryDropDown => driver.FindElement(By.XPath("//select[@name='subcategoryId']"));
        IWebElement Tags => driver.FindElement(By.XPath("//input[@class='ReactTags__tagInputField']"));
        IWebElement ServiceTypeOption => driver.FindElement(By.XPath("//input[@name='serviceType']"));
        IWebElement LocationTypeOption => driver.FindElement(By.XPath("//input[@name='locationType']"));
        IWebElement StartDateDropDown => driver.FindElement(By.XPath("//input[@name='startDate']")); 
        IWebElement EndDateDropDown => driver.FindElement(By.XPath("//input[@name='endDate']"));
        IWebElement Days=> driver.FindElement(By.XPath("//input[@name='Available']"));
        IWebElement SkillTradeOption => driver.FindElement(By.XPath("//input[@name='skillTrades']"));
        IWebElement SkillExchange => driver.FindElement(By.XPath("//input[@class='ReactTags__tagInputField']"));
        IWebElement ActiveOption => driver.FindElement(By.XPath("//input[@name='isActive']"));
        IWebElement SaveButton => driver.FindElement(By.XPath("//input[@value='Save']"));


        public void CreateShareSkill()
        {
            Wait.WaitForElementToBeClickable(driver, "XPath", "//a[@class='ui basic green button']", 20);
            //Click on Share Skill button
            ShareSkillButton.Click();

            //Enter Title
            Title.Click();
            Title.SendKeys("Automation script writting in c#");

            //Enter Description
            Description.Click();
            Description.SendKeys("I Would like to provide how to implement NUnit and Page Object Model");

            //Select Category
            CategoryDropDown.Click();
            SelectElement selectCategory = new SelectElement(driver.FindElement(By.Name("selectCategory")));
            selectCategory.SelectByText("Programming & Tech");

            //Select Sub Category
            SubCategoryDropDown.Click();
            SelectElement selectSubCategory = new SelectElement(driver.FindElement(By.Name("selectSubCategory")));
            selectSubCategory.SelectByText("QA");

            //Enter Tags
            Tags.Click();
            Tags.SendKeys("Testing");
        }

        public string GetAddedTitle()
        {
            IWebElement addedTitle = driver.FindElement(By.XPath("//input[@name='title']"));
            return addedTitle.Text;
        }
        public string GetAddedDescription()
        {
            IWebElement addedDescription = driver.FindElement(By.XPath("//textarea[@name='description']"));
            return addedDescription.Text;
        }
        public string GetAddedCategory()
        {
            IWebElement addedCategory = driver.FindElement(By.XPath("//select[@name='categoryId']"));
            return addedCategory.Text;
        }

    }
}
