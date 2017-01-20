using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_test
{
    [TestFixture]

    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            _applicationManager.GroupHelper.Remove(1);
        }
    }
}
