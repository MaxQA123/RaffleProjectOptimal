using NBitcoin;
using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            TitleFieldInputFixed.SendKeys("House from Dream");

            return this;
        }

        public CmsFixedOddsPage EnterSubtitle()
        {
            WaitUntil.ShouldLocate(By.XPath("//input[@id = 'subtitle']"));
            SubtitleFieldInputFixed.SendKeys("Address: ");
            SubtitleFieldInputFixed.SendKeys(Address.StreetAddress());

            return this;
        }

        public CmsFixedOddsPage EnterMetaTitleFixed()
        {
            WaitUntil.ShouldLocate(By.XPath("//input[@id = 'metaTitle']"));
            MetaTitleFieldInputFixed.SendKeys(TitleFieldInputFixed.GetAttribute("value"));

            return this;
        }

        public CmsFixedOddsPage EnterMetaDescription()
        {
            WaitUntil.ShouldLocate(By.XPath("//input[@id = 'metaDescription']"));
            MetaDescriptionInputFixed.SendKeys(AddingText.metadescription);
            MetaDescriptionInputFixed.SendKeys(SubtitleFieldInputFixed.GetAttribute("value"));

            return this;
        }

        public CmsFixedOddsPage EnterDescription()
        {
            WaitUntil.WaitSomeInterval(2);
            AddDescriptionInputFieldFixed.SendKeys("Descriptions about the house: ");
            AddDescriptionInputFieldFixed.SendKeys(Lorem.Sentence());

            return this;
        }

        public CmsFixedOddsPage SwitchingButtonActive()
        {
            WaitUntil.ElementIsClicable(SwitchButtonActiveFixed, 3);
            SwitchButtonActiveFixed.Click();

            return this;
        }

        public CmsFixedOddsPage SetStartDate()
        {
            WaitUntil.ElementIsClicable(StartDateInputDay, 3);
            Input.InputFunction(StartDateInputDay, "12");
            Input.InputFunction(StartDateInputMonth, "4");
            Input.InputFunction(StartDateInputYear, "2022");
            Input.InputFunction(StartDateInputHour, "14");
            Input.InputFunction(StartDateInputMinute, "49");
            Input.InputFunction(StartDateInputSecond, "33");
            SelectStartDateAmPm.SendKeys(Keys.ArrowDown);

            return this;
        }

        public CmsFixedOddsPage SetFinishDate()
        {
            WaitUntil.ElementIsClicable(FinishDateInputDay, 3);
            Input.InputFunction(FinishDateInputDay, "19");
            Input.InputFunction(FinishDateInputMonth, "11");
            Input.InputFunction(FinishDateInputYear, "2023");
            Input.InputFunction(FinishDateInputHour, "13");
            Input.InputFunction(FinishDateInputMinute, "40");
            Input.InputFunction(FinishDateInputSecond, "33");
            SelectFinishDateAmPm.SendKeys(Keys.ArrowDown);

            return this;
        }

        //public CmsFixedOddsPage ScrollToTabDiscountTickets()
        //{
        //    Scroll.ScrollToElement(TabButtonDiscountTicketsFixed);
        //    //WaitUntil.WaitSomeInterval(3);
        //    Thread.Sleep(5000);


        //    return this;
        //}

        public CmsFixedOddsPage ClickTabDiscountTickets()
        {
            WaitUntil.ElementIsClicable(TabButtonDiscountTicketsFixed);
            TabButtonDiscountTicketsFixed.SendKeys("");
            WaitUntil.WaitSomeInterval(3);
            TabButtonDiscountTicketsFixed.Click();

            return this;
        }

        #region Tab DiscountTickets

        public CmsFixedOddsPage EnterDataPriceNumberTickets()
        {
            WaitUntil.ElementIsClicable(TicketPriceInputField, 3);
            TicketPriceInputField.SendKeys("1.2");
            DefaultNumberTicketsInputField.SendKeys("19");
            NumberTicketsInputField.SendKeys("1873");

            return this;
        }

        //public CmsFixedOddsPage SwitchDiscountTickets()
        //{
        //    WaitUntil.ElementIsClicable(TicketsBlockDiscountTogglin);
        //    TicketsBlockDiscountTogglin.SendKeys("");
        //    WaitUntil.WaitSomeInterval(2);
        //    TicketsBlockDiscountTogglin.Click();

        //    return this;
        //}

        public CmsFixedOddsPage ClickSaveButtonTcktsDscnt()
        {
            WaitUntil.ElementIsClicable(SaveButtonTabTcktsDscnt);
            SaveButtonTabTcktsDscnt.Click();

            return this;
        }

        #endregion

    }
}