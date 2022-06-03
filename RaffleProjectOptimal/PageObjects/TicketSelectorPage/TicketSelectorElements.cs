using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.TicketSelectorPage
{
    public partial class TicketSelector
    {
        public IWebElement SelectAmountPlusOneTicket => Browser._Driver.FindElement(_selectAmountPlusOneTicket);
        public readonly static By _selectAmountPlusOneTicket = By.XPath("//ul[@class = 'ticket-selector__grid']/li[5]");

        public IWebElement SelectAmountPlusTenTicket => Browser._Driver.FindElement(_selectAmountPlusTenTicket);
        public readonly static By _selectAmountPlusTenTicket = By.XPath("//ul[@class = 'ticket-selector__grid']/li[6]");

        public IWebElement SelectAmountPlusTwntFiveTicket => Browser._Driver.FindElement(_selectAmountPlusTwntFiveTicket);
        public readonly static By _selectAmountPlusTwntFiveTicket = By.XPath("//ul[@class = 'ticket-selector__grid']/li[7]");

        public IWebElement SelectAmountMinusOneTicket => Browser._Driver.FindElement(_selectAmountMinusOneTicket);
        public readonly static By _selectAmountMinusOneTicket = By.XPath("//ul[@class = 'ticket-selector__grid']/li[1]");

        public IWebElement SelectAmountMinusTenTicket => Browser._Driver.FindElement(_selectAmountMinusTenTicket);
        public readonly static By _selectAmountMinusTenTicket = By.XPath("//ul[@class = 'ticket-selector__grid']/li[2]");

        public IWebElement SelectAmountMinusTwntFiveTicket => Browser._Driver.FindElement(_selectAmountMinusTwntFiveTicket);
        public readonly static By _selectAmountMinusTwntFiveTicket = By.XPath("//ul[@class = 'ticket-selector__grid']/li[3]");

        public IWebElement ClickButtonAddToBasketOnTcktSlctr => Browser._Driver.FindElement(_clickButtonAddToBasketOnTcktSlctr);
        public readonly static By _clickButtonAddToBasketOnTcktSlctr = By.XPath("//div[@class = 'enter-dialog__enter-button']/button/span");
    }
}
