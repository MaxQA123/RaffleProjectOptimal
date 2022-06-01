using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.WeeklyPrizesPage
{
    public partial class WeeklyPrizes
    {
        public IWebElement PopWndwOkButton => Browser._Driver.FindElement(_popWndwOkButton);
        public readonly static By _popWndwOkButton = By.XPath("//button[@class = 'rafflebtn primary full-width custom-width']");
        public IWebElement WeeklyCardPrizeTitle => Browser._Driver.FindElement(_weeklyCardPrizeTitle);
        public readonly static By _weeklyCardPrizeTitle = By.XPath("//h3[text() = 'Gordon Ramsay Experience']");
        public IWebElement EnterButtonWeeklyCard => Browser._Driver.FindElement(_enterButtonWeeklyCard);
        public readonly static By _enterButtonWeeklyCard = By.XPath("//*/article/div[1]/button");
    }
}