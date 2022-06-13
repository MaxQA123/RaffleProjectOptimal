using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.ForgotPasswordPage
{
    public partial class ForgotPasswordPg
    {
        public ForgotPasswordPg EnterEmailForgotPsswrd(string emailFrgtPsswrd)
        {
            WaitUntil.ShouldLocate(By.XPath("//input[@id = 'outlined-basic']"));
            FieldEmailForgotPassword.SendKeys(emailFrgtPsswrd);

            return this;
            
        }

        public ForgotPasswordPg ClickButtonRequest()
        {
            WaitUntil.ShouldLocate(By.XPath("//button[@class = 'rafflebtn full-width primary requestForgot']"));
            ButtonRequestFrgtPsswrd.Click();

            return this;
        }

        public ForgotPasswordPg EnterNewPassword(string newPassword)
        {
            WaitUntil.ElementIsClicable(FieldNewPasswordInputFrgtPsswrd);
            FieldNewPasswordInputFrgtPsswrd.SendKeys(newPassword);
            WaitUntil.WaitSomeInterval(3);
            FieldRepeatPsswrdInputFrgtPsswrd.SendKeys(newPassword);
            ButtonSetNemPsswrdFrgtPsswrd.Click();

            return this;
        }

        public ForgotPasswordPg ClickButtonBackToHomePage()
        {
            WaitUntil.WaitSomeInterval(3);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[0]);
            WaitUntil.WaitSomeInterval(2);
            WaitUntil.ElementIsClicable(ButtonBackToHomePage);
            ButtonBackToHomePage.Click();

            return this;
        }
    }
}
