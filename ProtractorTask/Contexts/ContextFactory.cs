using Protractor;
using System;

namespace ProtractorTests.Contexts
{
    public class ContextFactory
    {
        public T Create<T>(NgWebDriver driver) => (T)Activator.CreateInstance(typeof(T), driver);

        public TrendsHomePageContext TrendsHomePageContext(NgWebDriver driver) => new TrendsHomePageContext(driver);
        public TrendsExploreContext TrendsExploreContext(NgWebDriver driver) => new TrendsExploreContext(driver);

    }
}
