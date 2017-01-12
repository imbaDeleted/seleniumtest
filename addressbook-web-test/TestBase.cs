using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class TestBase
    {
        protected IWebDriver Driver;
        private StringBuilder _verificationErrors;
        protected string BaseUrl;
        protected LoginHelper LoginHelper;
        protected NavigationHelper NavigationHelper;
        protected GroupHelper GroupHelper;

        [SetUp]
        public void SetupTest()
        {
            Driver = new ChromeDriver();
            BaseUrl = "http://localhost:8080";
            _verificationErrors = new StringBuilder();
            LoginHelper = new LoginHelper(Driver);
            NavigationHelper = new NavigationHelper(Driver, BaseUrl);
            GroupHelper = new GroupHelper(Driver);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                Driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", _verificationErrors.ToString());
        }


    }
}