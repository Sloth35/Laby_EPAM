using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebDriverTest
{
    [TestFixture]
    public class WebDriverTest
    {
        [Test]
        public void Missing_arrival_point()
        {
            IWebDriver driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30)); ;
            driver.Navigate().GoToUrl("http://topavia.by/");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("sendpulse-disallow-btn")));
            driver.FindElement(By.ClassName("sendpulse-disallow-btn")).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("nemo-ui-dummiedInput__dummy")));
            driver.FindElement(By.ClassName("nemo-ui-dummiedInput__dummy")).Click();
            driver.FindElement(By.ClassName("nemo-ui-textInput__input")).SendKeys("Пекин, Шоуду, Китай");
            driver.FindElement(By.ClassName("nemo-ui-textInput__input")).SendKeys(Keys.Enter);
            driver.FindElement(By.ClassName("js-autofocus-field_arrival")).SendKeys(" ");
            driver.FindElement(By.ClassName("js-autofocus-field_date")).SendKeys("21.11.2018");
            driver.FindElement(By.ClassName("js-autofocus-field_date")).SendKeys(Keys.Enter);
            driver.FindElement(By.ClassName("nemo-flights-form__searchButton")).Click();
            Assert.AreEqual(driver.FindElement(By.ClassName("nemo-flights-form__route__segment__item__error")).Text, "Укажите пункт прилета", "Warning: Missing arrival point");
            driver.Quit();
        }
    }
}
