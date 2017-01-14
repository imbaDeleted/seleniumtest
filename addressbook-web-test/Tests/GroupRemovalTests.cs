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
            applicationManager.navigationHelper.GoToGroupsPage();
            applicationManager.groupHelper
                .SelectGroup(1)
                .RemoveGroup()
                .ReturnToGroupsPage();
        }
    }
}
