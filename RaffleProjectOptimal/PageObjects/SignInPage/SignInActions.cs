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
    public partial class SignIn : BaseWeb
    {
        [AllureStep]
        public SignIn EnterDataEmailPassword(string email, string password)
        {

            WaitUntil.ElementIsClicable(EmailInputField, 3);

            EmailInputField.SendKeys(email);
            PasswordInputField.SendKeys(password);
            SignInButton.Click();

            return this;
        }

    }
}
