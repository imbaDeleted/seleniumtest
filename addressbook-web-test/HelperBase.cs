using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class HelperBase
    {
        protected IWebDriver Driver;

        public HelperBase(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}