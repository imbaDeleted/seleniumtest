using NUnit.Framework;

namespace addressbook_web_test
{
    [SetUpFixture]
    public class TestSuiteFixture
    {


        [SetUp]
        public void InitApplicationManager()
        {
            ApplicationManager _applicationManager = ApplicationManager.GetInstance();
            //_applicationManager.BaseUrl = ;
            _applicationManager.NavigationHelper.GoToHomePage();
            _applicationManager.LoginHelper.Login(new AccountData("admin", "secret"));
        }
    }
}