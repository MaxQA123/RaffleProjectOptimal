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

        public IWebElement SwitchButtonActiveFixed => Browser._Driver.FindElement(_SwitchButtonActiveFixed);
        public readonly static By _SwitchButtonActiveFixed = By.XPath("//span[text() = 'Active']");

        #region StartDate
        public IWebElement StartDateInputDay => Browser._Driver.FindElement(_StartDateInputDay);
        public readonly static By _StartDateInputDay = By.XPath("//input[@name = 'day']");

        public IWebElement StartDateInputMonth => Browser._Driver.FindElement(_StartDateInputMonth);
        public readonly static By _StartDateInputMonth = By.XPath("//input[@name = 'month']");

        public IWebElement StartDateInputYear => Browser._Driver.FindElement(_StartDateInputYear);
        public readonly static By _StartDateInputYear = By.XPath("//input[@name = 'year']");

        public IWebElement StartDateInputHour => Browser._Driver.FindElement(_StartDateInputHour);
        public readonly static By _StartDateInputHour = By.XPath("//input[@name = 'hour12']");

        public IWebElement StartDateInputMinute => Browser._Driver.FindElement(_StartDateInputMinute);
        public readonly static By _StartDateInputMinute = By.XPath("//input[@name = 'minute']");

        public IWebElement StartDateInputSecond => Browser._Driver.FindElement(_StartDateInputSecond);
        public readonly static By _StartDateInputSecond = By.XPath("//input[@name = 'second']");

        public IWebElement SelectStartDateAmPm => Browser._Driver.FindElement(_SelectStartDateAmPm);
        public readonly static By _SelectStartDateAmPm = By.XPath("//select[@name = 'amPm']");

        #endregion
    }
}