using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace addressbook_web_test
{
    public class GroupHelper : HelperBase
    {

        public GroupHelper(ApplicationManager applicationManager) :base(applicationManager)
        {

        }

        public GroupHelper Create(GroupData group)
        {
            _applicationManager.NavigationHelper.GoToGroupsPage();

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
            groupCache = null;
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
            groupCache = null;
            return this;
        }

        public GroupHelper Remove(int n)
        {
            _applicationManager.NavigationHelper.GoToGroupsPage();
            SelectGroup(n);
            RemoveGroup();
            ReturnToGroupsPage();
            groupCache = null;
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            Driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();
            return this;
        }

        public GroupHelper Modify(int i, GroupData groupData)
        {
            _applicationManager.NavigationHelper.GoToGroupsPage();
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
            groupCache = null;
            return this;
        }

        private List<GroupData> groupCache = null;

        public List<GroupData> GetGroupList()
        {
            if (groupCache == null)
            {
                groupCache = new List<GroupData>();
                _applicationManager.NavigationHelper.GoToGroupsPage();

                //List<GroupData> groups = new List<GroupData>();

                ICollection<IWebElement> elements = Driver.FindElements(By.CssSelector("span.group"));
                foreach (IWebElement element in elements)
                {
                    groupCache.Add(new GroupData(null){
                            ID = element.FindElement(By.TagName("input")).GetAttribute("value")
                        });
                }

                string AllGroupNames = Driver.FindElement(By.CssSelector("dev#content form")).Text;
                string[] parts = AllGroupNames.Split('\n');
            }

            return new List<GroupData>(groupCache);
        }

        public int GetGroupCount()
        {
            return Driver.FindElements(By.CssSelector("span.group")).Count;
        }
    }
}