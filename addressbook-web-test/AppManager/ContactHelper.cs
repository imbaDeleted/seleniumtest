﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_test
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {

        }

        public ContactHelper Create(ContactData contact)
        {
            InitContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            return this;
        }

        public ContactHelper InitContactCreation()
        {
            Driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("middlename"), contact.MiddleName);
            Type(By.Name("lastname"), contact.LastName);
            Type(By.Name("nickname"), contact.NickName);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.Home);
            Type(By.Name("mobile"), contact.Mobile);
            Type(By.Name("work"), contact.Work);
            Type(By.Name("email"), contact.Email);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("homepage"), contact.HomePage);
            new SelectElement(Driver.FindElement(By.Name("bday"))).SelectByText(contact.Birthday);
            new SelectElement(Driver.FindElement(By.Name("bmonth"))).SelectByText(contact.BitrhMonth);
            Type(By.Name("byear"), contact.BithYear);
            Type(By.Name("address2"), contact.Address2);
            Type(By.Name("phone2"), contact.Phone2);
            Type(By.Name("notes"), contact.Notes);
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            Driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public ContactHelper Modify(string name, ContactData Contact)
        {

            Driver.FindElement(By.CssSelector("img[alt=\"Edit\"]")).Click();
            FillContactForm(Contact);
            Driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            Driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }

        public ContactHelper Remove(string name)
        {
            Driver.FindElement(By.Name("searchstring")).Clear();
            Driver.FindElement(By.Name("searchstring")).SendKeys(name);
            Driver.FindElement(By.Id("3")).Click();
            Driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            Driver.SwitchTo().Alert().Accept();
            //Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }
    }
}