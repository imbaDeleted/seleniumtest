using NUnit.Framework;

namespace addressbook_web_test
{
    [TestFixture]

    public class ContactCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            _applicationManager.ContactHelper.Create(new ContactData());
        }
    }
}