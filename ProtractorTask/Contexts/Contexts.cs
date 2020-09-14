using Protractor;

namespace ProtractorTests.Contexts
{
    public class ContextFactory
    {
        public TrendsHomePageContext TrendsHomePageContext(NgWebDriver driver) => new TrendsHomePageContext(driver);
        public TrendsExploreContext TrendsExploreContext(NgWebDriver driver) => new TrendsExploreContext(driver);

    }
}
