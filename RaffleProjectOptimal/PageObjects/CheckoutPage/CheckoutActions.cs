using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.CheckoutPage
{
    public partial class Checkout
    {
        public Checkout InputCardNumberCheckout(string cardnumber, string expirationdate, string cvv)
        {
            WaitUntil.WaitSomeInterval(10);
            Browser._Driver.SwitchTo().Frame(Iframe);
            WaitUntil.ElementIsClicable(FieldInputCardNumber, 5);
            FieldInputCardNumber.SendKeys(cardnumber);
            FieldExpirationDate.SendKeys(expirationdate);
            FieldInputCvv.SendKeys(cvv);

            return this;
        }
    }
}
