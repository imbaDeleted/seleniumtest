using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_web_test
{

    [TestFixture]
   // [Parallelizable]

    public class GroupModificationTests : AuthTestBase
    {
        [Test]

        public void GroupModificationTest()
        {
            var group = new GroupData("aaa", "bbbb", "cccc");

            List<GroupData> oldGroups = _applicationManager.GroupHelper.GetGroupList();

            GroupData oldData = oldGroups[0];

            _applicationManager.GroupHelper.Modify(0, group);

            Assert.AreEqual(oldGroups.Count, _applicationManager.GroupHelper.GetGroupCount());

            List<GroupData> newGroups = _applicationManager.GroupHelper.GetGroupList();
            oldGroups[0].Name = group.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData Group in newGroups)
            {
                if (Group.ID == oldData.ID)
                {
                    Assert.AreEqual(group.Name, Group.Name);
                }
            }
        }
    }
}