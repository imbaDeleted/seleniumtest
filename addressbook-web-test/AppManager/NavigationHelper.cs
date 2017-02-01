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

        public NavigationHelper(ApplicationManager applicationManager, string baseurl) :base(applicationManager)
        {
            this.Driver = _applicationManager.Driver;
            this.BaseUrl = baseurl;
            this._applicationManager = applicationManager;
        }

        public void GoToHomePage()
        {
            if (Driver.Url == BaseUrl + "/addressbook")
            {
                return;
            }
            Driver.Navigate().GoToUrl(BaseUrl + "/addressbook/");
        }

        public void GoToGroupsPage()
        {
            if (Driver.Url == BaseUrl + "/addressbook/group.php" && IsElementPresent(By.Name("New")))
            {
                return;
            }
            Driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}