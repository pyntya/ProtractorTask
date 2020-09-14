using eToroTestTask.Pages;
using Protractor;
using System;

namespace eToroTestTask.Contexts
{
    public class BaseContext <T> where T : BasePage
    {
        protected T Page;

        public BaseContext(NgWebDriver ngDriver)
        {
            Page = (T)Activator.CreateInstance(typeof(T), ngDriver);
        }
    }
}
