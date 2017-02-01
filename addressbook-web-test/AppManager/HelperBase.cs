using System.Xml.Schema;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

namespace addressbook_web_test
{
    public class HelperBase
    {
        protected IWebDriver Driver;
        protected ApplicationManager _applicationManager;

        public HelperBase(ApplicationManager applicationManager)
        {
            this._applicationManager = applicationManager;
            this.Driver = applicationManager.Driver;
        }

        public void Type(By locator, string text)
        {
            if (text != null)
            {
                Driver.FindElement(locator).Clear();
                Driver.FindElement(locator).SendKeys(text);
            }
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}