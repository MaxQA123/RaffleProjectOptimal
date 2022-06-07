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
        public CmsFixedOddsPage ClickLinkCreateFixed()
        {
            //WaitUntil.WaitSomeInterval(3);
            //WaitUntil.ElementIsClicable(LinkAddNewFixedOdds);
            WaitUntil.ShouldLocate(By.XPath("//a[@href = '#/fixedOdds/create']"));
            LinkAddNewFixedOdds.Click();

            return this;
        }
    }
}
