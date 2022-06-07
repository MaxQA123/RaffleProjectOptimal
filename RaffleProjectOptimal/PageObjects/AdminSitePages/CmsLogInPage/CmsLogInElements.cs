using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.AdminSitePages.CmsLogInPage
{
    public partial class CmsLogIn
    {
        public  IWebElement CmsInputFieldEmail => Browser._Driver.FindElement(_CmsInputFieldEmail);
        public readonly static By _CmsInputFieldEmail = By.XPath("//input[@id = 'standard-basic']");

        public IWebElement CmsInputFieldPassword => Browser._Driver.FindElement(_CmsInputFieldPassword);
        public readonly static By _CmsInputFieldPassword = By.XPath("//input[@id = 'standard-password-input']");

        public IWebElement CmsButtonSignIn => Browser._Driver.FindElement(_CmsButtonSignIn);
        public readonly static By _CmsButtonSignIn = By.XPath("//span[@class = 'MuiButton-label']");
    }
}
