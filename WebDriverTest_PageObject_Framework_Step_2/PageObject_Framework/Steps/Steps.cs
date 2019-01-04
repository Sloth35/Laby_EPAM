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
        Pages.Selection_0_passengers selection_0_passengers;
        Pages.Selection_only_straight_routes selection_only_straight_routes;
        Pages.Selection_only_straight_routes_and_buizness_class selection_only_straight_routes_and_buizness_class;
        Pages.Selection_only_straight_routes_and_not_fiill_departue_country selection_only_straight_routes_and_not_fiill_departue_country;
        Pages.Selection_only_straight_routes_and_return_date selection_only_straight_routes_and_return_date;
        Pages.Selection_only_straight_routes_plus_minus_two_days selection_only_straight_routes_plus_minus_two_days;
        Pages.Selection_only_straight_routes_use_undo_button selection_only_straight_routes_use_undo_button;
        Pages.Selection_routes_with_return_date selection_routes_with_return_date;


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
            selection_0_passengers = new Pages.Selection_0_passengers(this.driver);
            string departueDate = DateTime.Today.AddDays(+21).ToString();
            selection_0_passengers.Navigate();
            selection_0_passengers.Close_Sendpulse();
            selection_0_passengers.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            selection_0_passengers.Input_date(departueDate);
            selection_0_passengers.Choise_0_passengers();
        }
        public string Return_message_selection_0_passengers()
        {
            return selection_0_passengers.GetMessage();
        }

        public void Selection_only_straight_routes()
        {
            selection_only_straight_routes = new Pages.Selection_only_straight_routes(this.driver);
            string departueDate = DateTime.Today.AddDays(+21).ToString();
            selection_only_straight_routes.Navigate();
            selection_only_straight_routes.Close_Sendpulse();
            selection_only_straight_routes.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            selection_only_straight_routes.Input_date(departueDate);
            selection_only_straight_routes.Selection_only_straight_route();
            selection_only_straight_routes.Choise_2_passengers();
        }
        public string Return_message_selection_only_straight_routes()
        {
            return selection_only_straight_routes.GetMessage();
        }

        public void Selection_only_straight_routes_and_not_fiill_departue_country()
        {
            selection_only_straight_routes_and_not_fiill_departue_country = new Pages.Selection_only_straight_routes_and_not_fiill_departue_country(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            selection_only_straight_routes_and_not_fiill_departue_country.Navigate();
            selection_only_straight_routes_and_not_fiill_departue_country.Close_Sendpulse();
            selection_only_straight_routes_and_not_fiill_departue_country.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            selection_only_straight_routes_and_not_fiill_departue_country.Input_date(departueDate);
            selection_only_straight_routes_and_not_fiill_departue_country.Input_Departure_Date(arrivalDate);
            selection_only_straight_routes_and_not_fiill_departue_country.Selection_only_straight_route();
            selection_only_straight_routes_and_not_fiill_departue_country.Choise_2_passengers();
        }
        public string Return_message_selection_only_straight_routes_and_not_fiill_departue_country()
        {
            return selection_only_straight_routes_and_not_fiill_departue_country.GetMessage();
        }

        public void Selection_only_straight_routes_plus_minus_two_days()
        {
            selection_only_straight_routes_plus_minus_two_days = new Pages.Selection_only_straight_routes_plus_minus_two_days(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            selection_only_straight_routes_plus_minus_two_days.Navigate();
            selection_only_straight_routes_plus_minus_two_days.Close_Sendpulse();
            selection_only_straight_routes_plus_minus_two_days.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            selection_only_straight_routes_plus_minus_two_days.Input_date(departueDate);
            selection_only_straight_routes_plus_minus_two_days.Input_Departure_Date(arrivalDate);
            selection_only_straight_routes_plus_minus_two_days.Selection_plusMinus_two_days();
            //selection_only_straight_routes_plus_minus_two_days.Selection_only_straight_route();
            selection_only_straight_routes_plus_minus_two_days.Choise_2_passengers();
            selection_only_straight_routes_plus_minus_two_days.Selection_any_item();
        }
        public string Return_message_selection_only_straight_routes_plus_minus_two_days()
        {
            return selection_only_straight_routes_plus_minus_two_days.GetMessage();
        }

        public void Selection_only_straight_routes_and_buizness_class()
        {
            selection_only_straight_routes_and_buizness_class = new Pages.Selection_only_straight_routes_and_buizness_class(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            selection_only_straight_routes_and_buizness_class.Navigate();
            selection_only_straight_routes_and_buizness_class.Close_Sendpulse();
            selection_only_straight_routes_and_buizness_class.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            selection_only_straight_routes_and_buizness_class.Input_date(departueDate);
            selection_only_straight_routes_and_buizness_class.Input_Departure_Date(arrivalDate);
            selection_only_straight_routes_and_buizness_class.Selection_type_tickets();
            selection_only_straight_routes_and_buizness_class.Selection_only_straight_route();
            selection_only_straight_routes_and_buizness_class.Choise_2_passengers();
        }
        public string Return_message_selection_only_straight_routes_and_buizness_class()
        {
            return selection_only_straight_routes_and_buizness_class.GetMessage();
        }

        public void Selection_only_straight_routes_use_undo_button()
        {
            selection_only_straight_routes_use_undo_button = new Pages.Selection_only_straight_routes_use_undo_button(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            selection_only_straight_routes_use_undo_button.Navigate();
            selection_only_straight_routes_use_undo_button.Close_Sendpulse();
            selection_only_straight_routes_use_undo_button.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            selection_only_straight_routes_use_undo_button.Input_date(departueDate);
            selection_only_straight_routes_use_undo_button.Input_Departure_Date(arrivalDate);
            selection_only_straight_routes_use_undo_button.Selection_only_straight_route();
            selection_only_straight_routes_use_undo_button.Choise_2_passengers();
            selection_only_straight_routes_use_undo_button.Selection_button_edit();
        }
        public string Return_message_selection_only_straight_routes_use_undo_button()
        {
            return selection_only_straight_routes_use_undo_button.GetMessage();
        }

        public void Selection_only_straight_routes_and_return_date()
        {
            selection_only_straight_routes_and_return_date = new Pages.Selection_only_straight_routes_and_return_date(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            selection_only_straight_routes_and_return_date.Navigate();
            selection_only_straight_routes_and_return_date.Close_Sendpulse();
            selection_only_straight_routes_and_return_date.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            selection_only_straight_routes_and_return_date.Input_date(departueDate);
            selection_only_straight_routes_and_return_date.Input_Departure_Date(arrivalDate);
            selection_only_straight_routes_and_return_date.Selection_only_straight_route();
            selection_only_straight_routes_and_return_date.Choise_2_passengers();
        }
        public string Return_message_selection_only_straight_routes_and_return_date()
        {
            return selection_only_straight_routes_and_return_date.GetMessage();
        }

        public void Selection_routes_with_return_date()
        {
            selection_routes_with_return_date = new Pages.Selection_routes_with_return_date(this.driver);
            string departueDate = DateTime.Today.AddDays(+10).ToString();
            string arrivalDate = DateTime.Today.AddDays(+11).ToString();
            selection_routes_with_return_date.Navigate();
            selection_routes_with_return_date.Close_Sendpulse();
            selection_routes_with_return_date.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            selection_routes_with_return_date.Input_date(departueDate);
            selection_routes_with_return_date.Input_Departure_Date(arrivalDate);
            selection_routes_with_return_date.Selection_only_straight_route();
            selection_routes_with_return_date.Choise_2_passengers();
        }
        public string Return_message_selection_routes_with_return_date()
        {
            return selection_routes_with_return_date.GetMessage();
        }
        //public void SetPersonData(string Surname, string Name, string BirthDate)
        //{
        //    bookingPage = new Pages.BookingPage(this.driver);
        //    bookingPage.SetPersonData(Surname, Name, BirthDate);
        //}

        //public void SetPassportData(string PassportCountry, string PassportNumber, string PassportDate)
        //{
        //    bookingPage.SetPassportData(PassportCountry, PassportNumber, PassportDate);
        //}

        //public void SetCommunicationData(string Country, string Phone, string Email)
        //{
        //    bookingPage.SetCommunicationData(Country, Phone, Email);
        //}

        //public string GetBookingPageError()
        //{
        //    return bookingPage.GetErrorMessage();
        //}

        //public string GetMainPageError()
        //{
        //    return mainPage.GetErrorMessage();
        //}

        //public string GetBabyCount()
        //{
        //    return mainPage.GetBabyCount();
        //}
    }
}
