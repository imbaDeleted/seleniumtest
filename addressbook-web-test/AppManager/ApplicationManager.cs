using System;
using System.ComponentModel;
using System.Net;
using System.Security.Policy;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;


namespace addressbook_web_test
{
    public class ApplicationManager
    {
        protected IWebDriver _driver;
        protected string BaseUrl = "http://localhost:8080";

        protected LoginHelper _loginHelper;
        protected NavigationHelper _navigationHelper;
        protected GroupHelper _groupHelper;
        protected ContactHelper _contactHelper;
        private static ThreadLocal<ApplicationManager> _applicationManager = new ThreadLocal<ApplicationManager>();

        private ApplicationManager(string baseurl)
        {
            _driver = new ChromeDriver();
            BaseUrl = baseurl;
            _loginHelper = new LoginHelper(this);
            _navigationHelper = new NavigationHelper(this, BaseUrl);
            _groupHelper = new GroupHelper(this);
            _contactHelper = new ContactHelper(this);
        }

        ~ApplicationManager()
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

        public static ApplicationManager GetInstance(string url)
        {
            if (! _applicationManager.IsValueCreated)
            {
                ApplicationManager NewInstance = new ApplicationManager(url);
                _applicationManager.Value = NewInstance;
                NewInstance.NavigationHelper.GoToHomePage();
            }
            return _applicationManager.Value;
        }

        public LoginHelper LoginHelper
        {
            get { return _loginHelper; }
        }

        public NavigationHelper NavigationHelper
        {
            get {return _navigationHelper;}
        }

        public GroupHelper GroupHelper
        {
            get {return _groupHelper;}
        }

        public IWebDriver Driver
        {
            get { return _driver; }
        }

        public ContactHelper ContactHelper
        {
            get { return _contactHelper; }
        }
    }
}