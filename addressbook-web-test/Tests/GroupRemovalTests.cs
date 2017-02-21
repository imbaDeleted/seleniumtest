using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace addressbook_web_test
{
    [TestFixture]
    //[Parallelizable]

    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            List<GroupData> oldGroups = _applicationManager.GroupHelper.GetGroupList();

            _applicationManager.GroupHelper.Remove(0);

            Assert.AreEqual(oldGroups.Count-1, _applicationManager.GroupHelper.GetGroupCount());

            List<GroupData> newGroups = _applicationManager.GroupHelper.GetGroupList();

            foreach (var group in newGroups)
            {
                Assert.AreNotEqual(group.ID, oldGroups[0].ID);
            }

            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
