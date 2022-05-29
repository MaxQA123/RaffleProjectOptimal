﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.Additional
{
    public class WaitUntil
    {
        public static void ShoudLocate(IWebDriver webDriver, By location)
        {
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(location));
            }
            catch(WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"Cannot find out that app in specific location {location}", ex);
            }
        }
        public static void ElementIsClicable(IWebElement element, int seconds = 10)
        {
            new WebDriverWait(Browser._webDriver, TimeSpan.FromSeconds(seconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }
    }
}