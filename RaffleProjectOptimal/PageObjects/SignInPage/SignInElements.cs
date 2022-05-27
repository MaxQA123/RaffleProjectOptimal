using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.SignInPage
{
    public partial class SignInElements
    {
        public IWebElement EmailInputField => Browser._webDriver.FindElement(_emailInputField);
        public readonly static By _emailInputField = By.XPath("//input[@name = 'email']");

    }
}
