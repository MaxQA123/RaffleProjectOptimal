using NUnit.Allure.Steps;
using NUnit.Framework;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.SignInPage
{
    public partial class SignIn : WebBaseTests
    {
        [Test]
        public SignIn EnterData(string email, string password)
        {
            EmailInputField.FindElement(_emailInputField).SendKeys(email);
            PasswordInputField.FindElement(_passwordInputField).SendKeys(password);
            SignInButton.FindElement(_signInButton).Click();
        }

    }
}
