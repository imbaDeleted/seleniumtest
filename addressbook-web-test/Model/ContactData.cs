namespace addressbook_web_test
{
    public class ContactData
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
        private string _birthday;
        private string _bitrhMonth;
        private string _bithYear;
        private string _address2 = "ylica pushkina";
        private string _phone2 = "987654";
        private string _notes = "PREVED KAG DILA?";

        public ContactData(string firstname = "Grigory", string middlename = "Vitalevich", string lastname = "Fomin", string nickname = "Deleted", string title = "dunno",
            string company = "sravni", string address = "dom kolotuchkina", string homenumber = "111111", string mobilenumber = "222222", string worknumber = "33333",
            string email = "pam@pam.com", string homepage = "http://1111sad.io", string bday = "1", string bMonth = "December", string byear = "1990")
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
            _birthday = bday;
            _bitrhMonth = bMonth;
            _bithYear = byear;
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