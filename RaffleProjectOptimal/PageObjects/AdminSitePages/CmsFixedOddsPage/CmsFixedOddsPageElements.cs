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
        public IWebElement LinkAddNewFixedOdds => Browser._Driver.FindElement(_LinkAddNewFixedOdds);
        public readonly static By _LinkAddNewFixedOdds = By.XPath("//a[@href = '#/fixedOdds/create']");
    }
}