using NUnit.Allure.Steps;
using NUnit.Framework;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RaffleProjectOptimal.PageObjects.SignInPage
{
    public partial class SignIn
    {
        public SignIn EnterDataEmailPassword(string email, string password)
        {

            WaitUntil.ElementIsClicable(EmailInputField, 3);

            EmailInputField.SendKeys(email);
            PasswordInputField.SendKeys(password);

            return this;
        }

        public SignIn ClickSignInBtn()
        {
            SignInButton.Click();

            return this;
        }

        public SignIn ClickForgotPassword()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ShouldLocate(By.XPath("//span[text() = 'Forgot password?']"));
            ForgotPasswordLink.Click();

            return this;
        }

    }
}
