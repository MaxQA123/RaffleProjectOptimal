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
            //Thread.Sleep(2000);

            return this;
        }

        public ForgotPasswordPg EnterNewPassword(string newPassword)
        {
            WaitUntil.WaitSomeInterval(2);
            Browser._Driver.SwitchTo().DefaultContent();
            WaitUntil.WaitSomeInterval(2);
            WaitUntil.ElementIsClicable(FieldNewPasswordInputFrgtPsswrd);
            FieldNewPasswordInputFrgtPsswrd.SendKeys(newPassword);
            FieldRepeatPsswrdInputFrgtPsswrd.SendKeys(newPassword);

            return this;
        }
    }
}
