using eToroTestTask.Elements;
using eToroTestTask.Logging;
using OpenQA.Selenium;
using Protractor;
using System.Collections.Generic;

namespace eToroTestTask.Pages
{
    public class TrendsExplorePage : BasePage
    {
        public By GeoPikcerLocator => NgBy.Model("ctrl.model.geo");

        public NgWebElement GeoPicker
        {
            get
            {
                Logger.Log.Info(Logger.GetLoggingGetElementMessage(NgDriver, GeoPikcerLocator));
                return NgDriver.FindElement(GeoPikcerLocator);
            }
        }
        public NgWebElement SearchTextBox => GeoPicker.FindElement(By.TagName("input"));
        public IReadOnlyCollection<NgWebElement> GeoSuggestions => NgDriver.FindElements(By.XPath("//ul[@class='md-autocomplete-suggestions']//li"));
        public RelatedQueriesWidget SubRegionsWidget => new RelatedQueriesWidget(NgDriver, NgDriver.FindElement(By.XPath(GetRelatedQueriesWidgetLocator("Interest by subregion"))));
        public RelatedQueriesWidget RelatedQueriesWidget => new RelatedQueriesWidget(NgDriver, NgDriver.FindElement(By.XPath(GetRelatedQueriesWidgetLocator("Related queries"))));

        private string GetRelatedQueriesWidgetLocator(string widgetCaption) => $"//div[contains(text(), '{widgetCaption}')]/../../..";

        public TrendsExplorePage(NgWebDriver ngDriver) : base(ngDriver)
        {
        }
    }
}
