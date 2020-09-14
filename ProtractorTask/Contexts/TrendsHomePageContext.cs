using ProtractorTests.Pages;
using Protractor;
using System.Linq;

namespace ProtractorTests.Contexts
{
    public class TrendsHomePageContext : BaseContext<TrendsHomePage>
    {
        public TrendsHomePageContext(NgWebDriver ngDriver) : base(ngDriver)
        {
        }

        public TrendsHomePageContext SearchFor(string text)
        {
            Page.SearchField.SendKeys(text);
            return this;
        }

        public TrendsExploreContext ClickOnSuggestionByDescription(string suggestionDescription)
        {
            if (Page.Suggestions.Any(x => x.Description == suggestionDescription))
                Page.Suggestions.First(x => x.Description == suggestionDescription).Click();
            return new TrendsExploreContext(Page.GetDriver());
        }

        public TrendsExploreContext ClickOnSearchTermSuggestion()
        {
            return ClickOnSuggestionByDescription("Search term");
        }
    }
}
