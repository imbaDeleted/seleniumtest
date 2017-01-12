﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class LoginHelper : HelperBase
    {

        public LoginHelper(IWebDriver driver) : base(driver)
        {

        }
        public void Login(AccountData account)
        {
            Driver.FindElement(By.Name("user")).Clear();
            Driver.FindElement(By.Name("user")).SendKeys(account.Username);
            Driver.FindElement(By.Name("pass")).Clear();
            Driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            Driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
    }
}