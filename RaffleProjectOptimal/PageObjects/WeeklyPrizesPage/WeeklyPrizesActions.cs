﻿using RaffleProjectOptimal.Additional;
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
        public WeeklyPrizes ClickSldrArrowRght()
        {
            WaitUntil.ElementIsClicable(ArrowRightSldrCardPrizeWeekly, 5);
            ArrowRightSldrCardPrizeWeekly.Click();

            return this;
        }
        public WeeklyPrizes ClickSldrArrowLft()
        {
            WaitUntil.ElementIsClicable(ArrowLeftSldrCardPrizeWeekl, 5);
            ArrowLeftSldrCardPrizeWeekl.Click();

            return this;
        }
        public WeeklyPrizes SelectVart()
        {
            WaitUntil.ElementIsClicable(EnterButtonWeeklyCard, 5);
            EnterButtonWeeklyCard.SendKeys("");
            WaitUntil.WaitSomeInterval(5);
            EnterButtonWeeklyCard.Click();

            return this;
        }
    }
}
