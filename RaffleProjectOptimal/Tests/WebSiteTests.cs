using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using RaffleProjectOptimal.Additional;
using RaffleProjectOptimal.PageObjects;
using RaffleProjectOptimal.PageObjects.SignInPage;
using RaffleProjectOptimal.PageObjects.SignUpPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                .ClickSignInBtn();
            Pages.SignIn
                .VerifyIsSignIn();
            Thread.Sleep(5000);
        }

        [Test]

        public void RegNewUserByEmail()
        {
            Pages.Header
                .OpenSignUpPage();
            Pages.SignUp
                .EnterDataSignUp();
            string email = SignUp.GetEmail();
            Pages.SignUp
                .ClickSignUpBtn();
            Pages.SignUp
                .VerifyEmail(email);
            Thread.Sleep(5000);
        }

        [Test]

        public void OpenDreamHomePageViaHeader()
        {
            Pages.Header
                .OpenDrpDwnLiveCompetions();
            Pages.Header
                .OpenDreamHomePageViaDrpDwnLiveComp();
            Thread.Sleep(5000);
        }
        
    }
}
