using NUnit.Framework;
using RaffleProjectOptimal.Additional;
using RaffleProjectOptimal.PageObjects.SignInPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaffleAdminSite.Tests
{
    public class AdminCmsSiteTests : AdminBase
    {

        [Test]

        public void CmsLogInByEmail()
        {
            Pages.CmsLogIn
                .EnterEmailPasswordCms(Credentials.cmsemail, Credentials.cmspassword);
            Pages.CmsLogIn
                .ClickSigninButton();
            Pages.CmsHeader
                .OpenProfile();
            Pages.CmsPersonalDetailsPage
                .VerifyCmsIsSignIn();
            Thread.Sleep(5000);
        }

        [Test]

        public void CreateNewPrizeFixedOdds()
        {
            Pages.CmsLogIn
                .EnterEmailPasswordCms(Credentials.cmsemail, Credentials.cmspassword);
            Pages.CmsLogIn
                .ClickSigninButton();
            Pages.CmsSideBar
                .OpenFixedOddsPage();
            Pages.CmsFixedOddsPage
                .ClickLinkCreateFixed();
            Pages.CmsFixedOddsPage
                .UploadImages();
            Pages.CmsFixedOddsPage
                .EnterTitleFixed();
            Pages.CmsFixedOddsPage
                .EnterSubtitle();
            Pages.CmsFixedOddsPage
                .EnterDescription();
            Thread.Sleep(5000);
        }

    }
}