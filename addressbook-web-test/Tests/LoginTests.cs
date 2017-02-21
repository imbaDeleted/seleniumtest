using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]
   // [Parallelizable]

    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            _applicationManager.LoginHelper.Logout();

            AccountData account = new AccountData("admin", "secret");

            _applicationManager.LoginHelper.Login(account);
            Assert.IsTrue(_applicationManager.LoginHelper.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            _applicationManager.LoginHelper.Logout();

            AccountData account = new AccountData("admin", "123456");

            _applicationManager.LoginHelper.Login(account);
            Assert.IsFalse(_applicationManager.LoginHelper.IsLoggedIn(account));
        }
    }
}