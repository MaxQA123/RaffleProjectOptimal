using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects
{
    public partial class Header
    {
        public IWebElement buttonSignIn => Browser._Driver.FindElement(_buttonSignIn);
        public readonly static By _buttonSignIn = By.XPath("//button[text() = 'Sign In']");
        public IWebElement UserFirstNameBtn => Browser._Driver.FindElement(_userFirstNameBtn);
        public readonly static By _userFirstNameBtn = By.XPath("//*[@class='dropdownAccount ']/div[@class='header-drop-name']/span[1]");
        public IWebElement ButtonSignUp => Browser._Driver.FindElement(_buttonsignUp);
        public readonly static By _buttonsignUp = By.XPath("//a[@class='rafflebtn primary']");
    }
}