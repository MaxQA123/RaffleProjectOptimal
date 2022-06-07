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
        public CmsSideBar OpenFixedOddsPage()
        {
            WaitUntil.ShouldLocate(By.XPath("//div[@class = 'menu-wrap']/li[1]//span[@class = 'MuiTypography-root link MuiTypography-colorTextSecondary']"));
            PrizeManagementButtonDrp.Click();
            FixedOddsButton.Click();

            return this;
        }
    }
}
