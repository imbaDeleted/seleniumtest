using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class HelperBase
    {
        protected IWebDriver Driver;
        protected ApplicationManager Manager;

        public HelperBase(ApplicationManager manager)
        {
            this.Manager = manager;
            this.Driver = manager.Driver;
        }
    }
}