using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObject_Framework.Steps
{
    class Steps
    {
        IWebDriver driver;
        Pages.TopAviaPage topAviaPage;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }
        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }
        public void Selection_0_passengers()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+21).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Choise_0_passengers();
        }
        public string Return_message_selection_0_passengers()
        {
            return topAviaPage.GetMessage0Passengers();
        }
        public void Selection_only_straight_routes()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+21).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Selection_only_straight_route();
            topAviaPage.Choise_2_passengers();
        }
        public string Return_message_selection_only_straight_routes()
        {
            return topAviaPage.GetMessageOnlyStraightRoutes();
        }
        public void Selection_only_straight_routes_and_not_fiill_departue_country()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Input_Departure_Date(arrivalDate);
            topAviaPage.Selection_only_straight_route();
            topAviaPage.Choise_2_passengers();
        }
        public string Return_message_selection_only_straight_routes_and_not_fiill_departue_country()
        {
            return topAviaPage.GetMessageNotFillDepartueCountry();
        }
        public void Selection_only_straight_routes_plus_minus_two_days()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+1).ToString();
            string arrivalDate = DateTime.Today.AddDays(+2).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Input_Departure_Date(arrivalDate);
            topAviaPage.Selection_plusMinus_two_days();
            topAviaPage.Choise_2_passengers();
            topAviaPage.Selection_any_item();
        }
        public string Return_message_selection_only_straight_routes_plus_minus_two_days()
        {
            return topAviaPage.GetMessagePlusMinusTwoDays();
        }
        public void Selection_only_straight_routes_and_buizness_class()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Input_Departure_Date(arrivalDate);
            topAviaPage.Selection_type_tickets();
            topAviaPage.Selection_only_straight_route();
            topAviaPage.Choise_2_passengers();
        }
        public string Return_message_selection_only_straight_routes_and_buizness_class()
        {
            return topAviaPage.GetMessageBuzinessClass();
        }
        public void Selection_only_straight_routes_use_undo_button()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Input_Departure_Date(arrivalDate);
            topAviaPage.Selection_only_straight_route();
            topAviaPage.Choise_2_passengers();
            topAviaPage.Selection_button_edit();
        }
        public string Return_message_selection_only_straight_routes_use_undo_button()
        {
            return topAviaPage.GetMessageUseUndoButton();
        }
        public void Selection_only_straight_routes_and_return_date()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Input_Departure_Date(arrivalDate);
            topAviaPage.Selection_only_straight_route();
            topAviaPage.Choise_2_passengers();
        }
        public string Return_message_selection_only_straight_routes_and_return_date()
        {
            return topAviaPage.GetMessageReturnDate();
        }
        public void Selection_routes_with_return_date()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Input_Departure_Date(arrivalDate);
            topAviaPage.Selection_only_straight_route();
            topAviaPage.Choise_2_passengers();
        }
        public void Selection_only_straight_routes_with_return_date__moth_ago_use_undo_button()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+30).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Input_Departure_Date(arrivalDate);
            topAviaPage.Selection_only_straight_route();
            topAviaPage.Choise_2_passengers();
            topAviaPage.Selection_button_edit();
        }
        public void Selection_only_straight_routes_with_return_date_moth_ago_and_buizness_class()
        {
            topAviaPage = new Pages.TopAviaPage(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+30).ToString();
            topAviaPage.Navigate();
            topAviaPage.Close_Sendpulse();
            topAviaPage.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            topAviaPage.Input_date(departueDate);
            topAviaPage.Input_Departure_Date(arrivalDate);
            topAviaPage.Selection_type_tickets();
            topAviaPage.Selection_only_straight_route();
            topAviaPage.Choise_2_passengers();
        }
        public string Return_message_selection_routes_with_return_date()
        {
            return topAviaPage.GetMessageWithReturnDate();
        }
    }
}
