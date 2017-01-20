using System;
using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading;
using NUnit.Framework;
//using OpenQA.Selenium.Support.UI;

namespace addressbook_web_test
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            _applicationManager.GroupHelper.Create(new GroupData("aaa", "bbbb", "cccc"));
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            _applicationManager.GroupHelper.Create(new GroupData());
        }

    }
}
