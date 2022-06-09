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
        #region Tab General
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

        public IWebElement MetaTitleFieldInputFixed => Browser._Driver.FindElement(_MetaTitleFieldInputFixed);
        public readonly static By _MetaTitleFieldInputFixed = By.XPath("//input[@id = 'metaTitle']");

        public IWebElement MetaDescriptionInputFixed => Browser._Driver.FindElement(_MetaDescriptionInputFixed);
        public readonly static By _MetaDescriptionInputFixed = By.XPath("//input[@id = 'metaDescription']");

        //div[@class = 'ql-editor ql-blank']
        //div[@class = 'ql-container ql-snow']//div[1]
        public IWebElement AddDescriptionInputFieldFixed => Browser._Driver.FindElement(_AddDescriptionInputFieldFixed);
        public readonly static By _AddDescriptionInputFieldFixed = By.XPath("//div[@class = 'ql-container ql-snow']//div[1]");

        public IWebElement SwitchButtonActiveFixed => Browser._Driver.FindElement(_SwitchButtonActiveFixed);
        public readonly static By _SwitchButtonActiveFixed = By.XPath("//span[text() = 'Active']");

        #endregion

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

        #region FinishDate

        public IWebElement FinishDateInputDay => Browser._Driver.FindElement(_FinishDateInputDay);
        public readonly static By _FinishDateInputDay = By.XPath("//p[text() = 'Finish date']/parent::div//input[@name = 'day']");

        public IWebElement FinishDateInputMonth => Browser._Driver.FindElement(_FinishDateInputMonth);
        public readonly static By _FinishDateInputMonth = By.XPath("//p[text() = 'Finish date']/parent::div//input[@name = 'month']");

        public IWebElement FinishDateInputYear => Browser._Driver.FindElement(_FinishDateInputYear);
        public readonly static By _FinishDateInputYear = By.XPath("//p[text() = 'Finish date']/parent::div//input[@name = 'year']");

        public IWebElement FinishDateInputHour => Browser._Driver.FindElement(_FinishDateInputHour);
        public readonly static By _FinishDateInputHour = By.XPath("//p[text() = 'Finish date']/parent::div//input[@name = 'hour12']");

        public IWebElement FinishDateInputMinute => Browser._Driver.FindElement(_FinishDateInputMinute);
        public readonly static By _FinishDateInputMinute = By.XPath("//p[text() = 'Finish date']/parent::div//input[@name = 'minute']");

        public IWebElement FinishDateInputSecond => Browser._Driver.FindElement(_FinishDateInputSecond);
        public readonly static By _FinishDateInputSecond = By.XPath("//p[text() = 'Finish date']/parent::div//input[@name = 'second']");

        public IWebElement SelectFinishDateAmPm => Browser._Driver.FindElement(_SelectFinishDateAmPm);
        public readonly static By _SelectFinishDateAmPm = By.XPath("//p[text() = 'Finish date']/parent::div//select[@name = 'amPm']");

        #endregion

        #region Tabs

        public IWebElement TabButtonGeneralsFixed => Browser._Driver.FindElement(_TabButtonGeneralFixed);
        public readonly static By _TabButtonGeneralFixed = By.XPath("//a[@href = '#/fixedOdds/create/1']");

        public IWebElement TabButtonDiscountTicketsFixed => Browser._Driver.FindElement(_TabButtonDiscountTicketsFixed);
        public readonly static By _TabButtonDiscountTicketsFixed = By.XPath("//a[@href = '#/fixedOdds/create/1']");

        #endregion

        #region Tab DiscountTickets

        public IWebElement TicketPriceInputField => Browser._Driver.FindElement(_TicketPriceInputField);
        public readonly static By _TicketPriceInputField = By.XPath("//input[@id = 'ticketPrice']");

        public IWebElement DefaultNumberTicketsInputField => Browser._Driver.FindElement(_DefaultNumberTicketsInputField);
        public readonly static By _DefaultNumberTicketsInputField = By.XPath("//input[@id = 'defaultTickets']");

        public IWebElement NumberTicketsInputField => Browser._Driver.FindElement(_NumberTicketsInputField);
        public readonly static By _NumberTicketsInputField = By.XPath("//input[@id = 'maxTickets']");

        //label[@class = 'MuiFormControlLabel-root']//input[@id = 'isActiveDiscount']
        //input[@id = 'isActiveDiscount']
        public IWebElement TicketsBlockDiscountTogglin => Browser._Driver.FindElement(_TicketsBlockDiscountToggling);
        public readonly static By _TicketsBlockDiscountToggling = By.XPath("//input[@id = 'isActiveDiscount']");

        public IWebElement SaveButtonTabTcktsDscnt => Browser._Driver.FindElement(_SaveButtonTabTcktsDscnt);
        public readonly static By _SaveButtonTabTcktsDscnt = By.XPath("//button[@aria-label = 'Save']");

        #endregion
    }
}