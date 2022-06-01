using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.FixedOddsPage
{
    public partial class FixedOdds
    {
        public IWebElement EnterButtonFixedOddsPrize => Browser._Driver.FindElement(_enterButtonFixedOddsPrize);
        public readonly static By _enterButtonFixedOddsPrize = By.XPath("//button[text() = 'enter']");
    }
}
