using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.Header
{
    public partial class Header
    {
        public IWebElement SignInButton => Browser._webDriver.FindElement(_SignInBtn);
        public readonly static By _SignInBtn = By.XPath("//button[text() = 'Sign In']");
    }
}
