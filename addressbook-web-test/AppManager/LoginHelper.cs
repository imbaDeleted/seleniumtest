using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class LoginHelper : HelperBase
    {

        public LoginHelper(ApplicationManager applicationManager) : base(applicationManager)
        {

        }
        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }

                Logout();
            }

            Type(By.Name("user"),account.Username);
            Type(By.Name("pass"), account.Password);
            Driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn() && Driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text == "("+ account.Username +")";
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                Driver.FindElement(By.LinkText("Logout")).Click();
            }
        }
    }
}