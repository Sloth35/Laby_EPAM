using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebDriverTest_PageObject
{
    [TestFixture]
    public class AviaTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void Choise_0_passengers()
        {
            PageObject_AviaTest search_avia = new PageObject_AviaTest(driver);
            search_avia.Navigate();
            search_avia.Close_Sendpulse();
            search_avia.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            search_avia.Input_date("21.11.2018");
            search_avia.Choise_0_passengers();
            Assert.AreEqual(driver.FindElement(By.ClassName("nemo-flights-form__passengers__error")).Text, "Нет пассажиров", "Warning: Choised 0 passengers");
        }
    }
}
