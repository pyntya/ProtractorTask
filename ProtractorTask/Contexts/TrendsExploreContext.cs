using ProtractorTests.Pages;
using Protractor;
using System.Collections.Generic;
using System.Linq;

namespace ProtractorTests.Contexts
{
    public class TrendsExploreContext : BaseContext<TrendsExplorePage>
    {
        public TrendsExploreContext(NgWebDriver ngWebDriver) : base(ngWebDriver)
        {
        }

        public TrendsExploreContext SelectCountry(string countryName)
        {
            Page.GeoPicker.Click();
            Page.SearchTextBox.SendKeys(countryName);
            Page.GeoSuggestions.First(x => x.Text == countryName).Click();
            Page.WaitForAngular();
            return this;
        }

        public IEnumerable<string> VerifyIfSubRegionIsPresentInList()
        {
            Page.WaitForAngular();
            return Page.SubRegionsWidget.ItemTextValues;            
        }

        public TrendsExploreContext ClickOnSubRegion(string subRegion)
        {
            Page.SubRegionsWidget.ItemLabelElements.First(x => x.Text.Contains(subRegion)).Click();
            return this;
        }

        public int GetSubQueriesCount()
        {
            return Page.RelatedQueriesWidget.Items.Count;
        }
    }
}
