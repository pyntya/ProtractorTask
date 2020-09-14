using OpenQA.Selenium;
using Protractor;

namespace eToroTestTask.Elements
{
    public class SuggestionElement : NgWebElement
    {
        public string Title { get; }
        public string Description { get; }

        public SuggestionElement(NgWebDriver ngDriver, IWebElement element) : base(ngDriver, element)
        {
            Title = FindElement(By.CssSelector("div.autocomplete-title")).Text;
            Description = FindElement(By.CssSelector("div.autocomplete-desc")).Text;
        }
    }
}
