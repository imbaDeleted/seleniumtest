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

        public NavigationHelper(ApplicationManager manager, string baseurl) :base(manager)
        {
            this.Driver = Manager.Driver;
            this.BaseUrl = baseurl;
            this.Manager = manager;
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