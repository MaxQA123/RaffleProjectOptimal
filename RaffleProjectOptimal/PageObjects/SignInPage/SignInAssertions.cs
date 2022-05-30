﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;

namespace RaffleProjectOptimal.PageObjects.SignInPage
{
    public partial class SignIn
    {
        public SignIn VerifyIsSignIn()
        {
            WaitUntil.ElementVisibleAndClickable(By.XPath("//*[@class='dropdownAccount ']/div[@class='header-drop-name']/span[1]"), 1);

            Assert.IsTrue(Pages.Header.UserFirstNameBtn.Displayed);
            Console.WriteLine(Pages.Header.UserFirstNameBtn.Displayed);

            return this;
        }
   
    }
}
