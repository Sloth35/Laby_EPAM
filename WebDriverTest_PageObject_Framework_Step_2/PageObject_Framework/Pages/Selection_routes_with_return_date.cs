using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace PageObject_Framework.Pages
{
    public class Selection_routes_with_return_date
    {
        static IWebDriver driver;
        WebDriverWait wait;
        IJavaScriptExecutor js = driver as IJavaScriptExecutor;

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
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__routeOptions__item_direct")]
        public IWebElement selectStraightRoute { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__passengersPopUp__item__count_2")]
        public IWebElement selectTwoPassengers { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='nemo-flights-form__route__segment nemo-flights-form__route__segment_returnSegment']")]
        public IWebElement сallUpTheReverseDateSelectionMenu { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__route__segment__input_date_back")]
        public IWebElement enterDepartueDate { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")]
        public IWebElement returnMessage { get; set; }

        public Selection_routes_with_return_date(IWebDriver browser)
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

        public void Input_Departure_Date(string departure_date)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(сallUpTheReverseDateSelectionMenu));
            сallUpTheReverseDateSelectionMenu.Click();
            enterDepartueDate.SendKeys(departure_date);
            enterDepartueDate.SendKeys(Keys.Enter);
        }

        public void Selection_only_straight_route()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(selectStraightRoute));
            selectStraightRoute.Click();
        }
        public void Choise_2_passengers()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(clickTextboxPassengers));
            clickTextboxPassengers.Click();
            selectOtherOption.Click();
            selectTwoPassengers.Click();
            closeWindow.Click();
            clickSearchButton.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")));
        }

        public string GetMessage()
        {
            return returnMessage.Text;
        }
    }
}
