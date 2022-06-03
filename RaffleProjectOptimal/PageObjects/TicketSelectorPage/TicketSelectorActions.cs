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
        public TicketSelector SelectAmountPlusOneTicketForWeekly()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClicable(SelectAmountPlusOneTicket);
            SelectAmountPlusOneTicket.Click();

            return this;
        }
        public TicketSelector SelectAmountPlusTwntFvTicketForWeekly()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClicable(SelectAmountPlusTwntFiveTicket);
            SelectAmountPlusTwntFiveTicket.Click();

            return this;
        }
        public TicketSelector SelectAmountMinTenTicketForWeekly()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClicable(SelectAmountMinusTenTicket);
            SelectAmountMinusTenTicket.Click();

            return this;
        }
        public TicketSelector ClickAddToBasketButton()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClicable(ClickButtonAddToBasketOnTcktSlctr);
            ClickButtonAddToBasketOnTcktSlctr.Click();

            return this;
        }
    }
}
