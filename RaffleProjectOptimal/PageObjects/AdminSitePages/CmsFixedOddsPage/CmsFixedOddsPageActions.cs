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
        public CmsFixedOddsPage UploadImages()
        {
            WaitUntil.WaitSomeInterval(5);
            DesktopUploadImagesInput.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\")) + UploadedImages.DhRaffleHouse);
            MobileUploadImagesInput.SendKeys(Browser.RootPath() + UploadedImages.DhRaffleHouse);

            return this;
        }
        public CmsFixedOddsPage EnterTitleFixed()
        {
            WaitUntil.ShouldLocate(By.XPath("//input[@id = 'title']"));
            TitleFieldInputFixed.SendKeys(RandomGenerateData.RandomStringTitle(10));

            return this;
        }
        public CmsFixedOddsPage EnterSubtitle()
        {
            WaitUntil.ShouldLocate(By.XPath("//input[@id = 'subtitle']"));
            SubtitleFieldInputFixed.SendKeys(RandomGenerateData.RandomStringSubTitle(20));

            return this;
        }
        public CmsFixedOddsPage EnterDescription()
        {
            WaitUntil.ShouldLocate(By.XPath("//div[@class = 'ql-editor ql-blank']"));
            AddDescriptionInputFieldFixed.SendKeys(RandomGenerateData.RandomStringDescription(100));

            return this;
        }
    }
}