using System;
using System.Text;
using System.Collections.Generic;
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
            var group = new GroupData("aaa", "bbbb", "cccc");

            List<GroupData> oldGroups = _applicationManager.GroupHelper.GetGroupList();

            _applicationManager.GroupHelper.Create(group);

            Assert.AreEqual(oldGroups.Count+1, _applicationManager.GroupHelper.GetGroupCount());

            List<GroupData> newGroups = _applicationManager.GroupHelper.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            List<GroupData> oldGroups = _applicationManager.GroupHelper.GetGroupList();

            GroupData group = new GroupData();
            _applicationManager.GroupHelper.Create(group);

            Assert.AreEqual(oldGroups.Count+1, _applicationManager.GroupHelper.GetGroupCount());

            List<GroupData> newGroups = _applicationManager.GroupHelper.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups.Count, newGroups.Count);
        }

        [Test]
        public void BadGroupCreationTest()
        {
            List<GroupData> oldGroups = _applicationManager.GroupHelper.GetGroupList();

            GroupData group = new GroupData("a'a");

            _applicationManager.GroupHelper.Create(group);

            Assert.AreEqual(oldGroups.Count, _applicationManager.GroupHelper.GetGroupCount());

            List<GroupData> newGroups = _applicationManager.GroupHelper.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups.Count-1, newGroups.Count);
        }

    }
}
