using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_web_test
{
    [TestFixture]

    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            var Contact = new ContactData();

            List<ContactData> oldContacts = _applicationManager.ContactHelper.GetContactList();

            _applicationManager.ContactHelper.Create(Contact);

            List<ContactData> newContacts = _applicationManager.ContactHelper.GetContactList();
            oldContacts.Add(Contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts.Count, newContacts.Count);
        }
    }
}