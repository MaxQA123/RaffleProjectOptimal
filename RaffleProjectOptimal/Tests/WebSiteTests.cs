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
        [AllureTag("Regression")]
        [AllureOwner("Artem Sukharevskyi")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Artem", "qatester91311@gmail.com")]
        [AllureSuite("Client")]
        [AllureSubSuite("Login")]

        public void LogInByEmail()
        {
            Pages.Header
                .OpenSignInPage();
            Pages.SignIn
                .EnterDataEmailPassword(Credentials.email, Credentials.password);
        }
        
    }
}

/*public void LoginByEmail()
{
    Pages.Header
        .OpenSignInPage();
    Pages.SignIn
        .EnterLoginAndPass(Credentials.login, Credentials.password);
    Pages.SignIn
        .VerifyIsSignIn();

}*/
