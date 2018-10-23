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

            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.ClassName("sendpulse-disallow-btn")).Click();
            
            Driver.FindElement(By.ClassName("nemo-ui-dummiedInput__dummy")).Click();
            Driver.FindElement(By.ClassName("nemo-ui-textInput__input")).SendKeys("Пекин, Шоуду, Китай");
            Driver.FindElement(By.ClassName("nemo-ui-textInput__input")).SendKeys(Keys.Enter);

            Driver.FindElement(By.ClassName("js-autofocus-field_arrival")).SendKeys(" ");

            Driver.FindElement(By.ClassName("js-autofocus-field_date")).SendKeys("21.11.2018");
            Driver.FindElement(By.ClassName("js-autofocus-field_date")).SendKeys(Keys.Enter);

            Driver.FindElement(By.ClassName("nemo-flights-form__searchButton")).Click();

            Assert.AreEqual(Driver.FindElement(By.ClassName("nemo-flights-form__route__segment__item__error")).Text,"Укажите пункт прилета", "No point of arrival indicated");

            Driver.Close();
            Driver.Quit();
        }
    }
}
