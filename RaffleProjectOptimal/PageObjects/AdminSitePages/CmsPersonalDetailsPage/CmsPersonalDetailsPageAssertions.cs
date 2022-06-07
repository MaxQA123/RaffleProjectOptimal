using NUnit.Framework;
using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using RaffleProjectOptimal.PageObjects.SignInPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.AdminSitePages.CmsPersonalDetailsPage
{
    public partial class CmsPersonalDetailsPage
    {
        public CmsPersonalDetailsPage VerifyCmsIsSignIn()
        {
            WaitUntil.ElementVisible(By.XPath("//input[@name = 'firstName']"), 1);

            Assert.IsTrue(Pages.CmsPersonalDetailsPage.FirstNameInputField.Displayed);
            Console.WriteLine(Pages.CmsPersonalDetailsPage.FirstNameInputField.Displayed);

            return this;
        }
    }
}
