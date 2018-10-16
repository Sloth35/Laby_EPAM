using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject1
{
    [TestClass]
    public class WebDriverTest
    {
        [TestMethod]
        public void inability_to_order_past_date()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://topavia.by/");

            Driver.FindElement(By.ClassName("svg-search")).Click();
            Driver.FindElement(By.Id("title-search-input")).SendKeys("Минск");
            Driver.FindElement(By.ClassName("svg-black")).Click();
            Driver.Quit();
        }
    }
}
