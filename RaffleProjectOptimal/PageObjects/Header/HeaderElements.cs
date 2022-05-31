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
        public IWebElement ButtonSignUp => Browser._Driver.FindElement(_buttonSignUp);
        public readonly static By _buttonSignUp = By.XPath("//a[text() = 'Sign up']");
        public IWebElement LiveCompetionDrpDwn => Browser._Driver.FindElement(_liveCompetionDrpDwn);
        public readonly static By _liveCompetionDrpDwn = By.XPath("//span[text() = 'Live Competitions']");
        public IWebElement DreamHomeDrpDwnLiveComp => Browser._Driver.FindElement(_dreamHomeDrpDwnLiveComp);
        public readonly static By _dreamHomeDrpDwnLiveComp = By.XPath("//a/span[contains(text(), 'Dream Home')]");
        // //a/span[contains(text(), 'Dream Home')]
        // //a[@href = '/dreamhome']
    }
}