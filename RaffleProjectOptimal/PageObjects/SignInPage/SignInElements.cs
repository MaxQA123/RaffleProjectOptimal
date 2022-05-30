using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.SignInPage
{
    public partial class SignIn
    {
        public IWebElement HomePageSignInButton => Browser._Driver.FindElement(_homePageSignInButton);
        public readonly static By _homePageSignInButton = By.XPath("//button[text() = 'Sign In']");

        public IWebElement EmailInputField => Browser._Driver.FindElement(_emailInputField);
        public readonly static By _emailInputField = By.XPath("//input[@name = 'email']");

        public IWebElement PasswordInputField => Browser._Driver.FindElement(_passwordInputField);
        public readonly static By _passwordInputField = By.XPath("//input[@name = 'password']");

        public IWebElement SignInButton => Browser._Driver.FindElement(_signInButton);
        public readonly static By _signInButton = By.XPath("//button[text() = 'Sign In']");
    }
}
