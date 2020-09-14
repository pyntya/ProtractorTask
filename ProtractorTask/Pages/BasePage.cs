using Protractor;

namespace ProtractorTests.Pages
{
    public abstract class BasePage
    {
        protected NgWebDriver NgDriver { get; }

        public BasePage(NgWebDriver ngDriver)
        {
            NgDriver = ngDriver;
        }

        public void WaitForAngular()
        {
            NgDriver.WaitForAngular();
        }

        public NgWebDriver GetDriver() => NgDriver;
    }
}
