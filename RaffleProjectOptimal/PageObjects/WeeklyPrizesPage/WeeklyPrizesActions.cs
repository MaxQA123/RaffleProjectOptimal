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
        public WeeklyPrizes ClickButtonOkPopWndw()
        {
            WaitUntil.ElementIsClicable(PopWndwOkButton, 5);
            PopWndwOkButton.Click();

            return this;
        }

        public WeeklyPrizes SelectWeeklyPrize(string prize)
        {
            WaitUntil.ElementIsClicable(EnterButtonWeeklyCard, 5);
            Button.ClickEnterButtonWeekly(prize);

            return this;
        }
    }
}
