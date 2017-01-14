using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace addressbook_web_test
{
    public class ApplicationManager
    {
        protected IWebDriver Driver;
        protected string BaseUrl;

        protected LoginHelper LoginHelper;
        protected NavigationHelper NavigationHelper;
        protected GroupHelper GroupHelperHelper;

        public ApplicationManager(string baseurl)
        {
            Driver = new ChromeDriver();
            BaseUrl = baseurl;
            LoginHelper = new LoginHelper(this);
            NavigationHelper = new NavigationHelper(this, this.BaseUrl);
            GroupHelperHelper = new GroupHelper(this);
        }

        public void Stop()
        {
            try
            {
                Driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper loginHelper
        {
            get { return LoginHelper; }
        }

        public NavigationHelper navigationHelper
        {
            get {return NavigationHelper;}
        }

        public GroupHelper groupHelper
        {
            get {return GroupHelperHelper;}
        }

        public IWebDriver driver
        {
            get { return Driver; }
        }
    }
}