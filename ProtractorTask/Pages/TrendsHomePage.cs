using ProtractorTests.Elements;
using OpenQA.Selenium;
using Protractor;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProtractorTests.Pages
{
    public class TrendsHomePage : BasePage
    {
        public NgWebElement SearchField => NgDriver.FindElement(By.Id("input-254"));
        private NgWebElement SuggestionsUl => NgDriver.FindElement(By.Id("ul-254"));
        public IReadOnlyCollection<SuggestionElement> Suggestions =>
            new ReadOnlyCollection<SuggestionElement>(SuggestionsUl.FindElements(By.TagName("li")).Select(x => new SuggestionElement(NgDriver, x)).ToList());

        public TrendsHomePage(NgWebDriver ngDriver) : base(ngDriver)
        {
        }
    }

}

