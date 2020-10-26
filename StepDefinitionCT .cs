using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.Threading;
 

namespace CreativeTech1.Steps
{
    [Binding]
    public sealed class StepDefinitionCT
    {
        private IWebDriver _driver;
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist"); 
        }
        [When(@"I click on customer view details")]
        public void GivenIClickOnCustomerViewDetails()
        {
            _driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div[1]/div[2]/button")).Click();
            _driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div[2]/div[2]/button")).Click();
            _driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div[3]/div[2]/button")).Click();
        
        }
        [Then(@"I will see customer details")]
        public void ThenIWillSeeCustomerDetails()
        {
             
        }

    }

}
