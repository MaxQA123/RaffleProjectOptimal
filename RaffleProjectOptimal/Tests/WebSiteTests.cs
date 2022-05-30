using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleProjectOptimal.Additional;
using RaffleProjectOptimal.PageObjects;
using RaffleProjectOptimal.PageObjects.SignInPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.Tests
{
    public class WebSiteTests : TestBaseWeb
    {
        [Test]

        public void LogInByEmail()
        {
            Pages.Header
                .OpenSignInPage();
            Pages.SignIn
                .EnterDataEmailPassword(Credentials.email, Credentials.password);
            Pages.SignIn
                .VerifyIsSignIn();
        }
        
    }
}
