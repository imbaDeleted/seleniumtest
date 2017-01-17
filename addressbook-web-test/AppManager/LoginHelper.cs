using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class LoginHelper : HelperBase
    {

        public LoginHelper(ApplicationManager manager) : base(manager)
        {

        }
        public void Login(AccountData account)
        {
            Type(By.Name("user"),account.Username);
            Type(By.Name("pass"), account.Password);
            Driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
    }
}