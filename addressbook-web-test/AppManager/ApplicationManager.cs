using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace addressbook_web_test
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string BaseUrl;

        protected LoginHelper LoginHelper;
        protected NavigationHelper NavigationHelper;
        protected GroupHelper GroupHelper;

        public ApplicationManager(string baseurl)
        {
            driver = new ChromeDriver();
            BaseUrl = baseurl;
            LoginHelper = new LoginHelper(this);
            NavigationHelper = new NavigationHelper(this, this.BaseUrl);
            GroupHelper = new GroupHelper(this);
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

        public LoginHelper Auth
        {
            get { return LoginHelper; }
        }

        public NavigationHelper navigator
        {
            get {return NavigationHelper;}
        }

        public GroupHelper group
        {
            get {return GroupHelper;}
        }

        public IWebDriver Driver
        {
            get { return driver; }
        }
    }
}