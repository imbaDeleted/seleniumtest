﻿using NUnit.Framework;


namespace addressbook_web_test
{
    public class TestBase
    {

        protected ApplicationManager _applicationManager;

        [SetUp]
        public void SetupApplicationManager()
        {
            _applicationManager = ApplicationManager.GetInstance("http://localhost:8080");
            //_applicationManager.LoginHelper.Login(new AccountData("admin", "secret"));
        }
    }
}