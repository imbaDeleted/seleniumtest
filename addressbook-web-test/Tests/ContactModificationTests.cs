using NUnit.Framework;

namespace addressbook_web_test

{

    [TestFixture]
  //  [Parallelizable]

    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            _applicationManager.ContactHelper.Modify("Gri", new ContactData());
        }
    }
}