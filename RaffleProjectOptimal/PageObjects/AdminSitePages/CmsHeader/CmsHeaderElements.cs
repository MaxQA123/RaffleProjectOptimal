using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.AdminSitePages.CmsHeader
{
    public partial class CmsHeader
    {
        public IWebElement IconProfile => Browser._Driver.FindElement(_IconProfile);
        public readonly static By _IconProfile = By.XPath("//button[@title = 'Profile']");

        public IWebElement ButtonProfile => Browser._Driver.FindElement(_ButtonProfile);
        public readonly static By _ButtonProfile = By.XPath("//a[@href = '#/profile']");
    }
}
