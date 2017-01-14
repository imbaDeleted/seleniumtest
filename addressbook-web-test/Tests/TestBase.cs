using NUnit.Framework;


namespace addressbook_web_test
{
    public class TestBase
    {

        protected ApplicationManager applicationManager;

        [SetUp]
        public void SetupTest()
        {
            applicationManager = new ApplicationManager("http://localhost:8080");
            applicationManager.navigationHelper.GoToHomePage();
            applicationManager.loginHelper.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            applicationManager.Stop();
        }


    }
}