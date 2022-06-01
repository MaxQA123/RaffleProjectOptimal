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
        public FixedOdds SelectFixedOddsprize(string prize)
        {
            WaitUntil.ElementIsClicable(EnterButtonFixedOddsPrize);
            Button.ClickEnterButtonFixed(prize);

            return this;
        }
    }
}
