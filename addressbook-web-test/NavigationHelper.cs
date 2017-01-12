using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class NavigationHelper : HelperBase
    {
        private string BaseUrl;

        public NavigationHelper(IWebDriver driver, string baseurl) :base(driver)
        {
            this.BaseUrl = baseurl;
        }

        public void GoToHomePage()
        {
            Driver.Navigate().GoToUrl(BaseUrl + "/addressbook/");
        }

        public void GoToGroupsPage()
        {
            Driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}