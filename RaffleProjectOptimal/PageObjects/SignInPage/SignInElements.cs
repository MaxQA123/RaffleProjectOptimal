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
        //button[text() = 'Sign In']
        public IWebElement EmailInputField => Browser._Driver.FindElement(_emailInputField);
        public readonly static By _emailInputField = By.XPath("//input[@name = 'email']");

        public IWebElement PasswordInputField => Browser._Driver.FindElement(_passwordInputField);
        public readonly static By _passwordInputField = By.XPath("//input[@name = 'password']");

        public IWebElement SignInButton => Browser._Driver.FindElement(_signInButton);
        public readonly static By _signInButton = By.XPath("//*[@class='rafflebtn primary full-width']");

        public IWebElement ActualUserNameLog => Browser._Driver.FindElement(_actualUserNameLog);
        public readonly By _actualUserNameLog = By.XPath("//span[text() = 'Max']");
    }
}
