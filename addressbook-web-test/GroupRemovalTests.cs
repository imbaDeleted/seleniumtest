using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void  GroupRemovalTest()
        {
            NavigationHelper.GoToHomePage();
            LoginHelper.Login(new AccountData("admin", "secret"));
            NavigationHelper.GoToGroupsPage();
            GroupHelper.SelectGroup(1);
            GroupHelper.RemoveGroup();
            GroupHelper.ReturnToGroupsPage();
        }
    }
}
