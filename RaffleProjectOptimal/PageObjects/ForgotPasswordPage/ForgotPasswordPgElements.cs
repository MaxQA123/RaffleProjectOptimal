using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.ForgotPasswordPage
{
    public partial class ForgotPasswordPg
    {
        public IWebElement FieldEmailForgotPassword => Browser._Driver.FindElement(_FieldEmailForgotPassword);
        public readonly static By _FieldEmailForgotPassword = By.XPath("//input[@id = 'outlined-basic']");

        public IWebElement ButtonRequestFrgtPsswrd => Browser._Driver.FindElement(_ButtonRequestFrgtPsswrd);
        public readonly static By _ButtonRequestFrgtPsswrd = By.XPath("//button[@class = 'rafflebtn full-width primary requestForgot']");

        #region ForgotPasswordPageForEnterNewPassword

        public IWebElement IframeSetNewPasswordPag => Browser._Driver.FindElement(_IframeSetNewPasswordPage);
        public readonly static By _IframeSetNewPasswordPage = By.XPath("//div[@class = 'forgot-container-inner']");

        public IWebElement FieldNewPasswordInputFrgtPsswrd => Browser._Driver.FindElement(_FieldNewPasswordInputFrgtPsswrd);
        public readonly static By _FieldNewPasswordInputFrgtPsswrd = By.XPath("//div[@class = 'forgot-container-inner']//input[1]");

        public IWebElement FieldRepeatPsswrdInputFrgtPsswrd => Browser._Driver.FindElement(_FieldRepeatPsswrdInputFrgtPsswrd);
        public readonly static By _FieldRepeatPsswrdInputFrgtPsswrd = By.XPath("//input[@name ='confirmPassword']");

        public IWebElement ButtonSetNemPsswrdFrgtPsswrd => Browser._Driver.FindElement(_ButtonSetNemPsswrdFrgtPsswrd);
        public readonly static By _ButtonSetNemPsswrdFrgtPsswrd = By.XPath("//button[text() = 'Set new password']");

        public IWebElement ButtonBackToHomePage => Browser._Driver.FindElement(_ButtonBackToHomePage);
        public readonly static By _ButtonBackToHomePage = By.XPath("//button[text() = 'Back to home page']");

        #endregion
    }
}
