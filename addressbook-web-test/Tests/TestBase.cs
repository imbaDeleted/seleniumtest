using NUnit.Framework;


namespace addressbook_web_test
{
    public class TestBase
    {

        protected ApplicationManager _applicationManager;

        [SetUp]
        public void SetupTest()
        {
            _applicationManager = ApplicationManager.GetInstance();

        }
    }
}