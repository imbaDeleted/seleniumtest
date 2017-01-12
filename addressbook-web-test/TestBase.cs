using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class TestBase
    {
        protected IWebDriver _driver;
        private StringBuilder _verificationErrors;
        protected string _baseURL;

        [SetUp]
        public void SetupTest()
        {
            _driver = new ChromeDriver();
            _baseURL = "http://localhost:8080";
            _verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                _driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", _verificationErrors.ToString());
        }

        protected void GoToHomePage()
        {
            _driver.Navigate().GoToUrl(_baseURL + "/addressbook/");
        }


        protected void Login(AccountData account)
        {
            _driver.FindElement(By.Name("user")).Clear();
            _driver.FindElement(By.Name("user")).SendKeys(account.Username);
            _driver.FindElement(By.Name("pass")).Clear();
            _driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            _driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        protected void GoToGroupsPage()
        {
            _driver.FindElement(By.LinkText("groups")).Click();
        }

        protected void InitGroupCreation()
        {
            _driver.FindElement(By.Name("new")).Click();
        }

        protected void FillGroupForm(GroupData group)
        {
            _driver.FindElement(By.Name("group_name")).Clear();
            _driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            _driver.FindElement(By.Name("group_header")).Clear();
            _driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            _driver.FindElement(By.Name("group_footer")).Clear();
            _driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        protected void SubmitGroupCreation()
        {
            _driver.FindElement(By.Name("submit")).Click();
        }

        protected void ReturnToGroupsPage()
        {
            _driver.FindElement(By.LinkText("group page")).Click();
        }

        protected void RemoveGroup()
        {
            _driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
        }

        protected void SelectGroup(int index)
        {
            _driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }
    }
}