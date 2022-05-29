using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects
{
    public partial class Header
    {
        public IWebElement buttonSignIn => Browser._Driver.FindElement(_buttonSignIn);
        public readonly static By _buttonSignIn = By.XPath("//button[text() = 'Sign In']");
    }
}