using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace PageObject_Framework.Pages
{
    class Selection_0_passengers
    {
        IWebDriver driver;
        WebDriverWait wait;

        [FindsBy(How = How.ClassName, Using = "js-autofocus-field_date")]
        public IWebElement date { get; set; }
        [FindsBy(How = How.ClassName, Using = "sendpulse-disallow-btn")]
        public IWebElement sendpulse { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-ui-dummiedInput__dummy")]
        public IWebElement fieldToEnterDepartureCountry { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-ui-textInput__input")]
        public IWebElement enterDepartureCountry { get; set; }
        [FindsBy(How = How.Id, Using = "ui-id-1")]
        public IWebElement firstDropdownListItem { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__geoAC__item_aggregationRoot")]
        public IWebElement fieldToEnterDestinationCountry { get; set; }
        [FindsBy(How = How.ClassName, Using = "js-autofocus-field_arrival")]
        public IWebElement enterDestinationCountry { get; set; }
        [FindsBy(How = How.Id, Using = "ui-id-6")]
        public IWebElement sixthDropdownListItem { get; set; }
        [FindsBy(How = How.ClassName, Using = "js-flights-searchForm-passSelect")]
        public IWebElement clickTextboxPassengers { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='nemo-ui-select__dropdown__item nemo-flights-form__passengers__fastSelect__item'][4]")]
        public IWebElement selectOtherOption { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__passengersPopUp__item__count_0")]
        public IWebElement selectZeroPassengers { get; set; }
        [FindsBy(How = How.ClassName, Using = "ui-dialog-titlebar-close")]
        public IWebElement closeWindow { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__searchButton")]
        public IWebElement clickSearchButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__passengers__error")]
        public IWebElement returnMessage { get; set; }


        public Selection_0_passengers(IWebDriver browser)
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
            wait.Until(ExpectedConditions.ElementToBeClickable(sendpulse));
            sendpulse.Click();
        }
        public void Input_departue_and_destination_country(string departue_country, string destination_country)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(fieldToEnterDepartureCountry));
            fieldToEnterDepartureCountry.Click();
            enterDepartureCountry.SendKeys(departue_country);
            wait.Until(ExpectedConditions.ElementToBeClickable(firstDropdownListItem));
            fieldToEnterDestinationCountry.Click();
            enterDestinationCountry.SendKeys(destination_country);
            wait.Until(ExpectedConditions.ElementToBeClickable(sixthDropdownListItem));
            sixthDropdownListItem.Click();
        }
        public void Input_date(string input_date)
        {
            date.SendKeys(input_date);
            date.SendKeys(Keys.Enter);
        }
        public void Choise_0_passengers()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(clickTextboxPassengers));
            clickTextboxPassengers.Click();
            selectOtherOption.Click();
            selectZeroPassengers.Click();
            closeWindow.Click();
            clickSearchButton.Click();
        }
        public string GetMessage()
        {
            return returnMessage.Text;
        }
    }
}
