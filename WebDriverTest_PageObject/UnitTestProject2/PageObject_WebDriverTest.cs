using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectPattern
{
    public class PageObject_WebDriverTest
    {
        private readonly IWebDriver driver;
        private readonly string url = @"http://topavia.by/";

        public PageObject_WebDriverTest(IWebDriver browser)
        {
            this.driver = browser;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.ClassName, Using = "sendpulse-disallow-btn")]
        public IWebElement Chto_mashaet { get; set; }

        [FindsBy(How = How.ClassName, Using = "nemo-ui-dummiedInput__dummy")]
        public IWebElement Otkyda_letim { get; set; }

        [FindsBy(How = How.ClassName, Using = "nemo-ui-textInput__input")]
        public IWebElement Otkyda_letim_text { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-autofocus-field_arrival")]
        public IWebElement Kyda_letim_text { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-autofocus-field_date")]
        public IWebElement Date { get; set; }

        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__searchButton")]
        public IWebElement Knopka_Poisk { get; set; }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }
    }
}