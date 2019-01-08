using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace PageObject_Framework.Pages
{
    public class TopAviaPage
    {
        static IWebDriver driver;
        WebDriverWait wait;
        IJavaScriptExecutor js = driver as IJavaScriptExecutor;

        [FindsBy(How = How.ClassName, Using = "js-autofocus-field_date")]
        IWebElement date { get; set; }
        [FindsBy(How = How.ClassName, Using = "sendpulse-disallow-btn")]
        IWebElement sendpulse { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-ui-dummiedInput__dummy")]
        IWebElement fieldToEnterDepartureCountry { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-ui-textInput__input")]
        IWebElement enterDepartureCountry { get; set; }
        [FindsBy(How = How.Id, Using = "ui-id-1")]
        IWebElement firstDropdownListItem { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__geoAC__item_aggregationRoot")]
        IWebElement fieldToEnterDestinationCountry { get; set; }
        [FindsBy(How = How.ClassName, Using = "js-autofocus-field_arrival")]
        IWebElement enterDestinationCountry { get; set; }
        [FindsBy(How = How.Id, Using = "ui-id-6")]
        IWebElement sixthDropdownListItem { get; set; }
        [FindsBy(How = How.ClassName, Using = "js-flights-searchForm-passSelect")]
        public IWebElement clickTextboxPassengers { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='nemo-ui-select__dropdown__item nemo-flights-form__passengers__fastSelect__item'][4]")]
        IWebElement selectOtherOption { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__passengersPopUp__item__count_0")]
        IWebElement selectZeroPassengers { get; set; }
        [FindsBy(How = How.ClassName, Using = "ui-dialog-titlebar-close")]
        IWebElement closeWindow { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__searchButton")]
        IWebElement clickSearchButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__routeOptions__item_direct")]
        IWebElement selectStraightRoute { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[text()='Эконом']")]
        IWebElement typeTicket { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[text()='Бизнес']")]
        IWebElement selectBuzinesTickets { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__passengersPopUp__item__count_2")]
        IWebElement selectTwoPassengers { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='nemo-flights-form__route__segment nemo-flights-form__route__segment_returnSegment']")]
        IWebElement сallUpTheReverseDateSelectionMenu { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__route__segment__input_date_back")]
        IWebElement enterDepartueDate { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-results__summary__switch")]
        IWebElement selectButtonEdit { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__routeOptions__item_multiDate")]
        IWebElement selectPlusMinusTwoDays { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-results__matrix__table__cell_cheapest")]
        IWebElement selectAnyItem { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__passengers__error")]
        IWebElement returnMessage0Passengers { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")]
        IWebElement returnMessageOnlyStraightRoutes { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")]
        IWebElement returnMessageBuzinessClass { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")]
        IWebElement returnMessageNotFillDepartueCountry { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")]
        IWebElement returnMessageReturnDate { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-results__flightsGroup__leg__info__route__arrival")]
        IWebElement returnMessagePlusMinusTwoDays { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")]
        IWebElement returnMessageWithReturnDate { get; set; }
        [FindsBy(How = How.ClassName, Using = "nemo-flights-form__searchBlockedError")]
        IWebElement returnMessageUseUndoButton { get; set; }

        public TopAviaPage(IWebDriver browser)
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
        }
        public void Selection_button_edit()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(selectButtonEdit));
            selectButtonEdit.Click();
        }
        public void Selection_type_tickets()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(typeTicket));
            typeTicket.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(selectBuzinesTickets));
            selectBuzinesTickets.Click();
        }
        public void Selection_plusMinus_two_days()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(selectPlusMinusTwoDays));
            selectPlusMinusTwoDays.Click();
        }
        public void Selection_any_item()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(selectAnyItem));
            selectAnyItem.Click();
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
        public string GetMessageWithReturnDate()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")));
            return returnMessageWithReturnDate.Text;
        }
        public string GetMessagePlusMinusTwoDays()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("nemo-flights-results__flightsGroup__leg__info__route__arrival")));
            return returnMessagePlusMinusTwoDays.Text;
        }
        public string GetMessageReturnDate()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")));
            return returnMessageReturnDate.Text;
        }
        public string GetMessageNotFillDepartueCountry()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")));
            return returnMessageNotFillDepartueCountry.Text;
        }
        public string GetMessageBuzinessClass()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")));
            return returnMessageBuzinessClass.Text;
        }
        public string GetMessageOnlyStraightRoutes()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")));
            return returnMessageOnlyStraightRoutes.Text;
        }
        public string GetMessage0Passengers()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("nemo-flights-form__passengers__error")));
            return returnMessage0Passengers.Text;
        }
        public string GetMessageUseUndoButton()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("nemo-flights-form__searchBlockedError")));
            return returnMessageUseUndoButton.Text;
        }
    }
}
