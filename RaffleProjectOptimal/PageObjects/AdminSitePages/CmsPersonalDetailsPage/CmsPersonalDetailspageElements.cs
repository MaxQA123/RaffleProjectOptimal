using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.AdminSitePages.CmsPersonalDetailsPage
{
    public partial class CmsPersonalDetailsPage
    {
        public IWebElement FirstNameInputField => Browser._Driver.FindElement(_FirstNameInputField);
        public readonly static By _FirstNameInputField = By.XPath("//input[@name = 'firstName']");
    }
}
