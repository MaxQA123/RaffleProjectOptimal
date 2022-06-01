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
       public DreamHome SelectDreamHomePrize(string prize)
        {
            WaitUntil.ElementIsClicable(EnterButtonDreamHome);
            Button.ClickEnterButtonDream(prize);

            return this;
        }

    }
}
