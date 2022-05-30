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

namespace RaffleProjectOptimal.PageObjects.SignInPage
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T ();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }
        public static Header Header => GetPage<Header>();
        public static SignIn SignIn => GetPage<SignIn>();
    }
}
