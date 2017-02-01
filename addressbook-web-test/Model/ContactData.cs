using System;
using System.Security;

namespace addressbook_web_test
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _nickName;
        private string _title;
        private string _company;
        private string _address;
        private string _home;
        private string _mobile;
        private string _work;
        private string _email;
        private string _email2 = "dam@damdamd.com";
        private string _homePage;
        private string _birthday = "1";
        private string _bitrhMonth = "December";
        private string _bithYear = "1992";
        private string _address2 = "ylica pushkina";
        private string _phone2 = "987654";
        private string _notes = "PREVED KAG DILA?";

        public ContactData(string firstname = "Grigory", string lastname = null, string middlename = null, string nickname = null, string title = null,
            string company = null, string address = null, string homenumber = null, string mobilenumber = null, string worknumber = null,
            string email = null, string homepage = null)
        {
            _firstName = firstname;
            _middleName = middlename;
            _lastName = lastname;
            _nickName = nickname;
            _title = title;
            _company = company;
            _address = address;
            _home = homenumber;
            _mobile = mobilenumber;
            _work = worknumber;
            _email = email;
            _homePage = homepage;
        }

        public int CompareTo(ContactData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return 1;
            }
            if (FirstName.CompareTo(other.FirstName) == 1 && LastName.CompareTo(other.LastName) == 1)
            {
                return 1;
            }
            return 0;
        }

        public bool Equals(ContactData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return (FirstName == other.FirstName && LastName == other.LastName);
        }

        public override int GetHashCode()
        {
            return (FirstName.GetHashCode() + LastName.GetHashCode());
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string MiddleName
        {
            get { return _middleName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public string NickName
        {
            get { return _nickName; }
        }

        public string Title
        {
            get { return _title; }
        }

        public string Company
        {
            get { return _company; }
        }

        public string Address
        {
            get { return _address; }
        }

        public string Home
        {
            get { return _home; }
        }

        public string Mobile
        {
            get { return _mobile; }
        }

        public string Work
        {
            get { return _work; }
            set { _work = value; }
        }

        public string Email
        {
            get { return _email; }
        }

        public string Email2
        {
            get { return _email2; }
            set { _email2 = value; }
        }

        public string HomePage
        {
            get { return _homePage; }
        }

        public string Birthday
        {
            get { return _birthday; }
        }

        public string BitrhMonth
        {
            get { return _bitrhMonth; }
        }

        public string BithYear
        {
            get { return _bithYear; }
        }

        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }

        public string Phone2
        {
            get { return _phone2; }
            set { _phone2 = value; }
        }

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
    }
}