using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.DreamHomePage
{
    public partial class DreamHome
    {
        public IWebElement EnterButtonDreamHome => Browser._Driver.FindElement(_enterButtonDreamHome);
        public readonly static By _enterButtonDreamHome = By.XPath("//div[@class = 'dreamhome-card-footer']//button[@type = 'button']");
        public IWebElement EnterButtonGotItPoUpWndw => Browser._Driver.FindElement(_enterButtonGotItPoUpWndw);
        public readonly static By _enterButtonGotItPoUpWndw = By.XPath("//button[text() = 'Got it']");
    }
}
