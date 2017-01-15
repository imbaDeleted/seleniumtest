using NUnit.Framework;

namespace addressbook_web_test
{

    [TestFixture]

    public class GroupModificationTests : TestBase
    {
        [Test]

        public void GroupModificationTest()
        {
            _applicationManager.GroupHelper.Modify(1, new GroupData("asd", "bbb", "fuu"));
        }
    }
}