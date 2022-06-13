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
            Pages.DreamHome
                .ClickEnterBtnGotItPopWndw();
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
            Pages.DreamHome
                .ClickEnterBtnGotItPopWndw();
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

        public void OpenDreamHomePrizeViaHeader()
        {
            Pages.DreamHome
                .ClickEnterBtnGotItPopWndw();
;            Pages.Header
                .OpenDrpDwnLiveCompetions();
            Pages.Header
                .OpenDreamHomePageViaDrpDwnLiveComp();
            Pages.DreamHome
               .SelectDreamHomePrize("Find out more");
            Thread.Sleep(5000);
        }

        [Test]

        public void OpenWeeklyPrizeViaHeader()
        {
            Pages.DreamHome
                .ClickEnterBtnGotItPopWndw();
            Pages.Header
                .OpenDrpDwnLiveCompetions();
            Pages.Header
                .OpenWeeklyPrizesPageViaDrpDwnLiveComp();
            Pages.WeeklyPrizes
                .ClickButtonOkPopWndw();
            Pages.WeeklyPrizes
                .SelectWeeklyPrize("2 Night Yoga Retreat");
            Thread.Sleep(5000);
        }

        [Test]

        public void OpenFixedOddsPrizeViaHeader()
        {
            Pages.DreamHome
                .ClickEnterBtnGotItPopWndw();
            Pages.Header
                .OpenDrpDwnLiveCompetions();
            Pages.Header
                .OpenFixedOddsPageViaDrpDwnLiveComp();
            Pages.FixedOdds
                .SelectFixedOddsprize("enter");
            Thread.Sleep(5000);
        }

        [Test]

        public void BuyTicketsWeeklyPrize()
        {
            Pages.DreamHome
                .ClickEnterBtnGotItPopWndw();
            Pages.Header
                .OpenSignInPage();
            Pages.SignIn
                .EnterDataEmailPassword(Credentials.email, Credentials.password);
            Pages.SignIn
                .ClickSignInBtn();
            Pages.SignIn
                .VerifyIsSignIn();
            Pages.Header
                .OpenDrpDwnLiveCompetions();
            Pages.Header
                .OpenWeeklyPrizesPageViaDrpDwnLiveComp();
            Pages.WeeklyPrizes
                .ClickButtonOkPopWndw();
            Pages.WeeklyPrizes
               .SelectWeeklyPrize("2 Night Yoga Retreat");
            Pages.WeeklyPrizes
                 .ClickSldrArrowRght();
            Pages.WeeklyPrizes
                .ClickSldrArrowLft();
            Pages.WeeklyPrizes
                .ClcikButtonEnterNow();
            Pages.TicketSelector
                .SelectAmountPlusTwntFvTicketForWeekly();
            Pages.TicketSelector
                .SelectAmountMinTenTicketForWeekly();
            Pages.TicketSelector
                .ClickAddToBasketButton();
            Pages.Basket
                .ClickChangeAmountTicketsInBasket();
            Pages.TicketSelector
                .SelectAmountPlusOneTicketForWeekly();
            Pages.TicketSelector
                .ClickAddToBasketButton();
            Pages.Basket
                .ClickButtonCheckoutNowOnBasket();
            Pages.Checkout
                .InputCardNumberCheckout(Credentials.cardNumber, Credentials.expirationDate, Credentials.cvv);
            Pages.Checkout
                .ScrollToCheckBoxIAmCheckout();
            Pages.Checkout
                .ClickCheckBoxIAmCheckout();
            Pages.Checkout
                .ClickBtnCompleteOrderChcktPg();
            Thread.Sleep(5000);
        }

        [Test]

        public void ForgotPassword()
        {
            Pages.Header
                .OpenSignInPage();
            Pages.SignIn
                .ClickForgotPassword();
            Pages.ForgotPasswordPg
                .EnterEmailForgotPsswrd(Credentials.emailFrgtPsswrd);
            Pages.ForgotPasswordPg
                .ClickButtonRequest();
            Browser._Driver.Navigate().GoToUrl(EndPoints.ServiceXitroo);
            Pages.EmailBox
                .OpenNewLetterResetPassword();
            Pages.EmailBox
                .ClickLinkResetPassword();
            Pages.ForgotPasswordPg
                .EnterNewPassword(Credentials.newPassword);
            Pages.ForgotPasswordPg
                .ClickButtonBackToHomePage();
            Thread.Sleep(5000);
        }
   
    }
}