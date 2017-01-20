using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]

    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            _applicationManager.ContactHelper.Create(new ContactData());
        }
    }
}