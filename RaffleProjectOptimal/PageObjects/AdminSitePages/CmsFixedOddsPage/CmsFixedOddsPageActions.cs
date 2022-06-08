using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.IO;
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

    //public CmsFixedOddsPage ClickUplodImages()
    //    {
    //        WaitUntil.ShouldLocate(By.XPath("//p[@class = 'base-color add-image-title']"));
    //        DesktopUploadImagesInput.Click();

    //        return this;
    //    }
        public CmsFixedOddsPage UploadImages()
        {
            WaitUntil.WaitSomeInterval(5);
            DesktopUploadImagesInput.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")) + UploadedImages.DhRaffleHouse);
            MobileUploadImagesInput.SendKeys(Browser.RootPath() + UploadedImages.DhRaffleHouse);

            return this;
        }

    }
}
