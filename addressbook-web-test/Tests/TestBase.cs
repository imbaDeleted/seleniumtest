using NUnit.Framework;


namespace addressbook_web_test
{
    public class TestBase
    {

        protected ApplicationManager _applicationManager;

        [SetUp]
        public void SetupTest()
        {
            _applicationManager = new ApplicationManager("http://localhost:8080");
            _applicationManager.NavigationHelper.GoToHomePage();
            _applicationManager.LoginHelper.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            _applicationManager.Stop();
        }


    }
}