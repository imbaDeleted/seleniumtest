namespace addressbook_web_test
{
    public class GroupData
    {
        private string _name;
        private string _header;
        private string _footer;

        public GroupData(string name = "", string header = null, string footer = null)
        {
            this._name = name;
            this._header = header;
            this._footer = footer;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }

        public string Footer
        {
            get { return _footer; }
            set { _footer = value; }
        }
    }
}