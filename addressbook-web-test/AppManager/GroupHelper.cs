using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class GroupHelper : HelperBase
    {

        public GroupHelper(ApplicationManager manager) :base(manager)
        {

        }

        public GroupHelper Create(GroupData group)
        {
            Manager.NavigationHelper.GoToGroupsPage();

            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            Driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            Driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            Driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        public GroupHelper RemoveGroup()
        {
            Driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
            return this;
        }

        public GroupHelper Remove(int n)
        {
            Manager.NavigationHelper.GoToGroupsPage();
            SelectGroup(n);
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            Driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public GroupHelper Modify(int i, GroupData groupData)
        {
            Manager.NavigationHelper.GoToGroupsPage();
            SelectGroup(i);
            InitGroupModification();
            FillGroupForm(groupData);
            SubmitGroupModification();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            Driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            Driver.FindElement(By.Name("update")).Click();
            return this;
        }
    }
}