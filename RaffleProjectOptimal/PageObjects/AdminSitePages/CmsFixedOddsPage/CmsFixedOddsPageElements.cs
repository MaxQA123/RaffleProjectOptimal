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

        public IWebElement DesktopUploadImagesInput => Browser._Driver.FindElement(_DesktopUploadImagesInput);
        public readonly static By _DesktopUploadImagesInput = By.XPath("//div[@class = 'dropzone'][1]//input[@type = 'file']");

        public IWebElement MobileUploadImagesInput => Browser._Driver.FindElement(_MobileUploadImagesInput);
        public readonly static By _MobileUploadImagesInput = By.XPath("//div[@class = 'dropzone'][2]//input[@type = 'file']");

        public IWebElement TitleFieldInputFixed => Browser._Driver.FindElement(_TitleFieldInputFixed);
        public readonly static By _TitleFieldInputFixed = By.XPath("//input[@id = 'title']");

        public IWebElement SubtitleFieldInputFixed => Browser._Driver.FindElement(_SubtitleFieldInputFixed);
        public readonly static By _SubtitleFieldInputFixed = By.XPath("//input[@id = 'subtitle']");

        public IWebElement AddDescriptionInputFieldFixed => Browser._Driver.FindElement(_AddDescriptionInputFieldFixed);
        public readonly static By _AddDescriptionInputFieldFixed = By.XPath("//div[@class = 'ql-editor ql-blank']");
    }
}