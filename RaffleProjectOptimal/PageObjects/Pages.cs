using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using RaffleProjectOptimal.Additional;
using RaffleProjectOptimal.PageObjects.SignInPage;
using NUnit.Framework;
using RaffleProjectOptimal.PageObjects.SignUpPage;
using RaffleProjectOptimal.PageObjects.WeeklyPrizesPage;
using RaffleProjectOptimal.PageObjects.DreamHomePage;
using RaffleProjectOptimal.PageObjects.FixedOddsPage;
using RaffleProjectOptimal.PageObjects.TicketSelectorPage;
using RaffleProjectOptimal.PageObjects.BasketPage;
using RaffleProjectOptimal.PageObjects.CheckoutPage;

namespace RaffleProjectOptimal.PageObjects.SignInPage
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }
        public static Header Header => GetPage<Header>();
        public static SignIn SignIn => GetPage<SignIn>();
        public static SignUp SignUp => GetPage<SignUp>();
        public static WeeklyPrizes WeeklyPrizes => GetPage<WeeklyPrizes>();
        public static DreamHome DreamHome => GetPage<DreamHome>();
        public static FixedOdds FixedOdds => GetPage<FixedOdds>();
        public static TicketSelector TicketSelector => GetPage<TicketSelector>();
        public static Basket Basket => GetPage<Basket>();
        public static Checkout Checkout => GetPage<Checkout>();
        public static Scroll Scroll => GetPage<Scroll>();
    }
}