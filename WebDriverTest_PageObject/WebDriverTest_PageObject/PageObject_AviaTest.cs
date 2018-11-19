using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace WebDriverTest_PageObject
{
    class PageObject_AviaTest
    {
        IWebDriver driver;
        WebDriverWait wait;

        [FindsBy(How = How.ClassName, Using = "js-autofocus-field_date")]
        public IWebElement date { get; set; }

        public PageObject_AviaTest(IWebDriver browser)
        {
            driver = browser;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Manage().Window.Maximize();
            PageFactory.InitElements(browser, this);
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("http://topavia.by/");
        }
        public void Close_Sendpulse()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("sendpulse-disallow-btn")));
            driver.FindElement(By.ClassName("sendpulse-disallow-btn")).Click();
        }
        public void Input_departue_and_destination_country(string departue_country, string destination_country)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("nemo-ui-dummiedInput__dummy")));
            driver.FindElement(By.ClassName("nemo-ui-dummiedInput__dummy")).Click();
            driver.FindElement(By.ClassName("nemo-ui-textInput__input")).SendKeys(departue_country);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("ui-id-1")));
            driver.FindElement(By.ClassName("nemo-flights-form__geoAC__item_aggregationRoot")).Click();
            driver.FindElement(By.ClassName("js-autofocus-field_arrival")).SendKeys(destination_country);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("ui-id-6")));
            driver.FindElement(By.Id("ui-id-6")).Click();
        }
        public void Input_date(string input_date)
        {
            date.SendKeys(input_date);
            date.SendKeys(Keys.Enter);
        }
        public void Choise_0_passengers()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("js-flights-searchForm-passSelect")));
            driver.FindElement(By.ClassName("js-flights-searchForm-passSelect")).Click();
            driver.FindElement(By.XPath("//div[@class='nemo-ui-select__dropdown__item nemo-flights-form__passengers__fastSelect__item'][4]")).Click();
            driver.FindElement(By.ClassName("nemo-flights-form__passengersPopUp__item__count_0")).Click();
            driver.FindElement(By.ClassName("ui-dialog-titlebar-close")).Click();
            driver.FindElement(By.ClassName("nemo-flights-form__searchButton")).Click();
        }
    }
}
