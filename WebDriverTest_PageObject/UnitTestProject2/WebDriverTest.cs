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
            PageObject_WebDriverTest poiskAvia = new PageObject_WebDriverTest(this.Driver);
            poiskAvia.Navigate();
            System.Threading.Thread.Sleep(5000);

            poiskAvia.Chto_mashaet.Click();

            poiskAvia.Otkyda_letim.Click();
            poiskAvia.Otkyda_letim_text.SendKeys("Пекин,");
            System.Threading.Thread.Sleep(2000);

            poiskAvia.Kyda_letim_text.SendKeys("");
            System.Threading.Thread.Sleep(2000);

            poiskAvia.Date.SendKeys("21.11.2018");
            poiskAvia.Date.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(2000);

            poiskAvia.Knopka_Poisk.Click();

            Assert.AreEqual(Driver.FindElement(By.ClassName("nemo-flights-form__route__segment__item__error")).Text, "Укажите пункт прилета", "No point of arrival indicated");
        }
    }
}