using log4net;
using log4net.Config;
using OpenQA.Selenium;

namespace ProtractorTests.Logging
{
    public class Logger
    {
        private static ILog log = LogManager.GetLogger("Logger");
        public static string GetLoggingGetElementMessage(IWebDriver driver, By locator) => $"Get {locator}. WindowHandle: {driver.CurrentWindowHandle}.";
        public static string GetLoggingOneTimeSetupMessage(IWebDriver driver) =>
            $"Test execution is started using {driver.GetType()} driver. WindowHandle: {driver.CurrentWindowHandle}.";
        public static string GetLoggingOneTimeTeardownMessage(IWebDriver driver) =>
            $"Test execution using {driver.GetType()} driver is finised. WindowHandle: {driver.CurrentWindowHandle}.";

        public static ILog Log
        {
            get { return log; }
        }

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}
