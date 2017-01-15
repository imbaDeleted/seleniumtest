using NUnit.Framework;

namespace addressbook_web_test

{

    [TestFixture]

    public class ContactModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            _applicationManager.ContactHelper.Modify("gri", new ContactData());
        }
    }
}