using NUnit.Framework;

namespace addressbook_web_test

{
    [TestFixture]

    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            if (_applicationManager.ContactHelper.ContactExist())
            {
                _applicationManager.ContactHelper.Remove();
            }
            else
            {
                _applicationManager.ContactHelper.Create(new ContactData());
                _applicationManager.ContactHelper.Remove();
            }

        }
    }
}