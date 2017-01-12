using System;
using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading;
using NUnit.Framework;
//using OpenQA.Selenium.Support.UI;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            NavigationHelper.GoToHomePage();
            LoginHelper.Login(new AccountData("admin", "secret"));
            NavigationHelper.GoToGroupsPage();
            GroupHelper.InitGroupCreation();
            GroupHelper.FillGroupForm(new GroupData("aaa", "bbbb", "cccc"));
            GroupHelper.SubmitGroupCreation();
            GroupHelper.ReturnToGroupsPage();
        }
    }
}
