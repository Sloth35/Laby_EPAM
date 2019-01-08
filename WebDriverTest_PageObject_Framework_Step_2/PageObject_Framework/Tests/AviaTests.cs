using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PageObject_Framework.Pages
{
    [TestFixture]
    public class AviaTests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void SetupTest()
        {
            steps.InitBrowser();
        }
        [TearDown]
        public void TeardownTest()
        {
            steps.CloseBrowser();
        }
        [Test]
        public void Selection_0_passengers()
        {
            steps.Selection_0_passengers();
            Assert.AreEqual(steps.Return_message_selection_0_passengers(), "Нет пассажиров", "Warning: Choised 0 passengers");
        }
        [Test]
        public void Selection_only_straight_routes()
        {
            steps.Selection_only_straight_routes();
            Assert.AreEqual(steps.Return_message_selection_only_straight_routes(), "Без пересадок", "Warning: Showing flights with transfers");
        }
        [Test]
        public void Selection_only_straight_routes_and_not_fiill_departue_country()
        {
            steps.Selection_only_straight_routes_and_not_fiill_departue_country();
            Assert.AreEqual(steps.Return_message_selection_only_straight_routes_and_not_fiill_departue_country(), "Без пересадок", "Warning: Showing flights with transfers");
        }
        [Test]
        public void Selection_only_straight_routes_plus_minus_two_days()
        {
            steps.Selection_only_straight_routes_plus_minus_two_days();
            Assert.AreEqual(steps.Return_message_selection_only_straight_routes_plus_minus_two_days(), "Нью-Йорк", "Warning: Showing flights with transfers");
        }
        [Test]
        public void Selection_only_straight_routes_and_buizness_class()
        {
            steps.Selection_only_straight_routes_and_buizness_class();
            Assert.AreEqual(steps.Return_message_selection_only_straight_routes_and_buizness_class(), "Без пересадок", "Warning: Showing flights with transfers");
        }
        [Test]
        public void Selection_only_straight_routes_use_undo_button()
        {
            steps.Selection_only_straight_routes_use_undo_button();
            Assert.AreEqual(steps.Return_message_selection_only_straight_routes_use_undo_button(), "Поменяйте что-нибудь", "Warning: Showing flights with transfers");
        }
        [Test]
        public void Selection_only_straight_routes_and_return_date()
        {
            steps.Selection_only_straight_routes_and_return_date();
            Assert.AreEqual(steps.Return_message_selection_only_straight_routes_and_return_date(), "Без пересадок", "Warning: Showing flights with transfers");
        }
        [Test]
        public void Selection_routes_with_return_date()
        {
            steps.Selection_routes_with_return_date();
            Assert.AreEqual(steps.Return_message_selection_routes_with_return_date(), "Без пересадок", "Warning: Showing flights with transfers");
        }
    }
}
