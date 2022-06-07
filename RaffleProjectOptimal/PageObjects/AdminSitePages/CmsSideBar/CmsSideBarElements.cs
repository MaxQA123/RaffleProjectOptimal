using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.AdminSitePages.CmsSideBar
{
    public partial class CmsSideBar
    {
        public IWebElement PrizeManagementButtonDrp => Browser._Driver.FindElement(_PrizeManagementButtonDrp);
        public readonly static By _PrizeManagementButtonDrp = By.XPath("//div[@class = 'menu-wrap']/li[1]//span[@class = 'MuiTypography-root link MuiTypography-colorTextSecondary']");

        public IWebElement FixedOddsButton => Browser._Driver.FindElement(_FixedOddsButton);
        public readonly static By _FixedOddsButton = By.XPath("//div[@class = 'MuiList-root jss33']/a[3]");
    }
}
