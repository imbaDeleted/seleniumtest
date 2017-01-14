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
            applicationManager.groupHelper.Create(new GroupData("aaa", "bbbb", "cccc"));
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            applicationManager.groupHelper.Create(new GroupData());
        }

    }
}
