using OpenQA.Selenium;
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
            Driver.FindElement(By.Name("firstname")).Clear();
            Driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            Driver.FindElement(By.Name("middlename")).Clear();
            Driver.FindElement(By.Name("middlename")).SendKeys(contact.MiddleName);
            Driver.FindElement(By.Name("lastname")).Clear();
            Driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            Driver.FindElement(By.Name("nickname")).Clear();
            Driver.FindElement(By.Name("nickname")).SendKeys(contact.NickName);
            Driver.FindElement(By.Name("title")).Clear();
            Driver.FindElement(By.Name("title")).SendKeys(contact.Title);
            Driver.FindElement(By.Name("company")).Clear();
            Driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            Driver.FindElement(By.Name("address")).Clear();
            Driver.FindElement(By.Name("address")).SendKeys(contact.Address);
            Driver.FindElement(By.Name("home")).Clear();
            Driver.FindElement(By.Name("home")).SendKeys(contact.Home);
            Driver.FindElement(By.Name("mobile")).Clear();
            Driver.FindElement(By.Name("mobile")).SendKeys(contact.Mobile);
            Driver.FindElement(By.Name("work")).Clear();
            Driver.FindElement(By.Name("work")).SendKeys(contact.Work);
            Driver.FindElement(By.Name("email")).Clear();
            Driver.FindElement(By.Name("email")).SendKeys(contact.Email);
            Driver.FindElement(By.Name("email2")).Clear();
            Driver.FindElement(By.Name("email2")).SendKeys(contact.Email2);
            Driver.FindElement(By.Name("homepage")).Clear();
            Driver.FindElement(By.Name("homepage")).SendKeys(contact.HomePage);
            new SelectElement(Driver.FindElement(By.Name("bday"))).SelectByText(contact.Birthday);
            new SelectElement(Driver.FindElement(By.Name("bmonth"))).SelectByText(contact.BitrhMonth);
            Driver.FindElement(By.Name("byear")).Clear();
            Driver.FindElement(By.Name("byear")).SendKeys(contact.BithYear);
            Driver.FindElement(By.Name("address2")).Clear();
            Driver.FindElement(By.Name("address2")).SendKeys(contact.Address2);
            Driver.FindElement(By.Name("phone2")).Clear();
            Driver.FindElement(By.Name("phone2")).SendKeys(contact.Phone2);
            Driver.FindElement(By.Name("notes")).Clear();
            Driver.FindElement(By.Name("notes")).SendKeys(contact.Notes);
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