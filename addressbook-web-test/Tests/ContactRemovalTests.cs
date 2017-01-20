using NUnit.Framework;

namespace addressbook_web_test

{
    [TestFixture]

    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            _applicationManager.ContactHelper.Remove("Gri");
        }
    }
}