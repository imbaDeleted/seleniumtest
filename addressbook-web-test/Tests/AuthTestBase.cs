using NUnit.Framework;

namespace addressbook_web_test
{
    public class AuthTestBase : TestBase
    {
        [SetUp]

        public void SetupLogin()
        {
            _applicationManager.LoginHelper.Login(new AccountData("admin", "secret"));
        }
    }
}