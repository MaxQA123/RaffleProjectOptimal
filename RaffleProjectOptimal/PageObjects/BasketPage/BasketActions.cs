using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.BasketPage
{
    public partial class Basket
    {
        public Basket ClickChangeAmountTicketsInBasket()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClicable(ChangeTicketsInBasket);
            ChangeTicketsInBasket.Click();

            return this;
        }

        public Basket ClickButtonCheckoutNowOnBasket()
        {
            WaitUntil.WaitSomeInterval(1);
            WaitUntil.ElementIsClicable(ButtonCheckoutNowOnBasket);
            ButtonCheckoutNowOnBasket.SendKeys("");
            WaitUntil.WaitSomeInterval(3);
            ButtonCheckoutNowOnBasket.Click();

            return this;
        }
    }
}
