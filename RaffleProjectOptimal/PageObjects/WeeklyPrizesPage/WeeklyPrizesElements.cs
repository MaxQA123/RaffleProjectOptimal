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
        public readonly static By _popWndwOkButton = By.XPath("//div[@class = 'ReactModal__Content ReactModal__Content--after-open freeToWinModalWrapper']//button[text() = 'OK']");
        public IWebElement EnterButtonWeeklyCard => Browser._Driver.FindElement(_enterButtonWeeklyCard);
        public readonly static By _enterButtonWeeklyCard = By.XPath("//*/article/div[1]/button");
        
        
        // Page CardWeeklyPrizes
        public IWebElement ArrowRightSldrCardPrizeWeekly => Browser._Driver.FindElement(_arrowRightSldrCardPrizeWeekly);
        public readonly static By _arrowRightSldrCardPrizeWeekly = By.XPath("//div[@class = 'mat-carousel-container']/button[2]");
        public IWebElement ArrowLeftSldrCardPrizeWeekl => Browser._Driver.FindElement(_arrowLeftSldrCardPrizeWeekly);
        public readonly static By _arrowLeftSldrCardPrizeWeekly = By.XPath("//div[@class = 'mat-carousel-container']/button[1]");
    }
}