using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectPattern
{
    [TestClass]
    public class BingTests
    {
        public IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new FirefoxDriver();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void SearchTextInBing()
        {
            PageObject_WebDriverTest googleMainPage = new PageObject_WebDriverTest(this.Driver);
            googleMainPage.Navigate();
            System.Threading.Thread.Sleep(5000);

            googleMainPage.Chto_mashaet.Click();

            googleMainPage.Otkyda_letim.Click();
            googleMainPage.Otkyda_letim_text.SendKeys("Пекин,");
            System.Threading.Thread.Sleep(2000);

            googleMainPage.Kyda_letim_text.SendKeys("");
            System.Threading.Thread.Sleep(2000);

            googleMainPage.Date.SendKeys("21.11.2018");
            googleMainPage.Date.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(2000);

            googleMainPage.Knopka_Poisk.Click();

            Assert.AreEqual(Driver.FindElement(By.ClassName("nemo-flights-form__route__segment__item__error")).Text, "Укажите пункт прилета", "No point of arrival indicated");
        }
    }
}