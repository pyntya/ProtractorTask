using ProtractorTests.Contexts;
using ProtractorTests.Tests;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Linq;

namespace ProtractorTests
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    [Parallelizable(ParallelScope.Self)]
    public class GoogleTrendsTests<TWebDriver> : BaseTest<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        [Test]
        [TestCase("Selenium", "Israel", "Tel Aviv", 0)]
        public void SearchForTrendInCountryAndVerifySubRegionRelatedQueriesCount(string searchParameter, string country, string subRegion, int expectedSubQueriesCount)
        {
            ngWebDriver.Url = BaseUrl;

            var subRegions = ContextFactory.TrendsHomePageContext(ngWebDriver)
                .SearchFor(searchParameter)
                .ClickOnSearchTermSuggestion()
                .SelectCountry(country)
                .VerifyIfSubRegionIsPresentInList();
            var subQueriesCount = ContextFactory.TrendsExploreContext(ngWebDriver)
                .ClickOnSubRegion(subRegion)
                .GetSubQueriesCount();

            subRegions.Any(x => x.Contains(subRegion)).Should().BeTrue($"{subRegion} subregion should be present in Subregions list");
            subQueriesCount.Should().Be(expectedSubQueriesCount, "search result should contain expected number of related queries");
        }
    }
}
