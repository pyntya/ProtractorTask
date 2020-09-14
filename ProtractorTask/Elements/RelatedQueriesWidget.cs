using OpenQA.Selenium;
using Protractor;
using System.Collections.Generic;
using System.Linq;

namespace ProtractorTests.Elements
{
    public class RelatedQueriesWidget : NgWebElement
    {
        public IReadOnlyCollection<NgWebElement> Items => FindElements(By.ClassName("item"));
        public IEnumerable<string> ItemTextValues => ItemLabelElements.Select(x => x.Text);
        public IReadOnlyCollection<NgWebElement> ItemLabelElements => FindElements(By.XPath(".//span[@ng-bind='bidiText']"));

        public RelatedQueriesWidget(NgWebDriver ngDriver, IWebElement element) : base(ngDriver, element)
        {
        }
    }
}
