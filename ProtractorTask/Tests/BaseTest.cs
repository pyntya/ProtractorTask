using eToroTestTask.Helpers;
using eToroTestTask.Logging;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using System;

namespace eToroTestTask.Tests
{
    public abstract class BaseTest<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        protected IWebDriver driver;
        protected NgWebDriver ngWebDriver;
        protected string BaseUrl => ConfigurationHelper.BaseUrl;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = typeof(TWebDriver) == typeof(ChromeDriver) ?
                (TWebDriver)(new ChromeDriver($@"{AppDomain.CurrentDomain.BaseDirectory}\Drivers") as IWebDriver) :
                new TWebDriver();
            driver.Manage().Window.Maximize();
            ngWebDriver = new NgWebDriver(driver);
            Logger.InitLogger();
            Logger.Log.Info(Logger.GetLoggingOneTimeSetupMessage(driver));
        }


        [OneTimeTearDown]
        public void TearDown()
        {
            Logger.Log.Info(Logger.GetLoggingOneTimeTeardownMessage(driver));
            driver.Quit();
        }
    }
}
