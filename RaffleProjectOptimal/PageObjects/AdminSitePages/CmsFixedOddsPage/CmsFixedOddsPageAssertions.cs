using NUnit.Framework;
using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.AdminSitePages.CmsFixedOddsPage
{
    public partial class CmsFixedOddsPage
    {
        public static string GetTitle()
        {
            string getTitle = Browser._Driver.FindElement(By.XPath("//input[@id = 'title']")).GetAttribute("value");
            string titlefixedodds = getTitle.ToString();

            return titlefixedodds;
        }
        public CmsFixedOddsPage VerifyIsFixedOddsCreatedSucsessfully(string titlefixedodds)
        {
            string titlefixedoddsConpare = TitleFieldInputFixed.GetAttribute("value");

            Assert.AreEqual(titlefixedodds, titlefixedoddsConpare);

            return this;
        }

    }
}