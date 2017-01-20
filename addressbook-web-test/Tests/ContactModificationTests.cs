using NUnit.Framework;

namespace addressbook_web_test

{

    [TestFixture]

    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            _applicationManager.ContactHelper.Modify("Gri", new ContactData());
        }
    }
}