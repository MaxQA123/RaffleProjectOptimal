using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.SignUpPage
{
    public partial class SignUp
    {
        public IWebElement FirstNameInputField => Browser._Driver.FindElement(_firstNameInputField);
        public readonly static By _firstNameInputField = By.XPath("//input[@name ='name']");
        public IWebElement LastNameInputField => Browser._Driver.FindElement(_lastNameInputField);
        public readonly static By _lastNameInputField = By.XPath("//input[@name ='surname']");
        public IWebElement EmailInputField => Browser._Driver.FindElement(_emaiInputField);
        public readonly static By _emaiInputField = By.XPath("//input[@name ='email']");
        public IWebElement PhoneNumInutField => Browser._Driver.FindElement(_phoneNumberInputField);
        public readonly static By _phoneNumberInputField = By.XPath("//input[@class ='phone-input']");
        public IWebElement PasswordInputField => Browser._Driver.FindElement(_passwordInputField);
        public readonly static By _passwordInputField = By.XPath("//input[@name ='password']");
        public IWebElement IamCheckBox => Browser._Driver.FindElement(_iAMCheckBox);
        public readonly static By _iAMCheckBox = By.XPath("//p[@class ='checkboxDesc']");
        public IWebElement OptInCheckBox => Browser._Driver.FindElement(_optInCheckBox); 
        public readonly static By _optInCheckBox = By.XPath("//p[contains(text(), 'Opt in to receive email')]");
        public IWebElement RememberMeCheckBox => Browser._Driver.FindElement(_rememberMeCheckBox);
        public readonly static By _rememberMeCheckBox = By.XPath("//span[text() = 'Remember me']");
        public IWebElement SignUpButton => Browser._Driver.FindElement(_signUpButton);
        public readonly static By _signUpButton = By.XPath("//button[@class = 'rafflebtn primary full-width']");
    }
}