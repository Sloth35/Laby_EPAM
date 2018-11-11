using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject2.Pages
{
    [TestClass]
    public class AviaTest
    {
        public IWebDriver driver;

        [TestInitialize]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [TestMethod]
        public void Search_avia()
        {
            SearchAvia search_avia = new SearchAvia(driver);
            search_avia.Navigate();
            search_avia.Close_Sendpulse();
            search_avia.Input_departue_and_destination_country();
            search_avia.Input_date();
            search_avia.Selection_only_straight_route();
            search_avia.Choise_2_passengers();
            Assert.AreEqual(driver.FindElement(By.ClassName("nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")).Text, "Без пересадок", "Warning: Showing flights with transfers");
        }
    }
}
