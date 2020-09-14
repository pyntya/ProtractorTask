using ProtractorTests.Pages;
using Protractor;
using System;

namespace ProtractorTests.Contexts
{
    public abstract class BaseContext<T> where T : BasePage
    {
        protected T Page;

        public BaseContext(NgWebDriver ngDriver)
        {
            Page = (T)Activator.CreateInstance(typeof(T), ngDriver);
        }
    }
}
