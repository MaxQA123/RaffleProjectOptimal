using OpenQA.Selenium;
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
            WaitUntil.ElementIsClicable(FieldInputCardNumber, 60);
            FieldInputCardNumber.SendKeys(cardnumber);
            FieldExpirationDate.SendKeys(expirationdate);
            FieldInputCvv.SendKeys(cvv);
            WaitUntil.WaitSomeInterval(1);
            Browser._Driver.SwitchTo().DefaultContent();

            return this;
        }

        public Checkout ScrollToCheckBoxIAmCheckout()
        {
            Scroll.ScrollBottom(CheckBoxIAmCheckout);

            return this;
        }

        public Checkout ClickCheckBoxIAmCheckout()
        {
            WaitUntil.WaitSomeInterval(3);
            CheckBoxIAmCheckout.Click();

            return this;
        }

        public Checkout ClickBtnCompleteOrderChcktPg()
        {
            WaitUntil.WaitSomeInterval(1);
            //WaitUntil.ElementIsClicable(ButtonCompleteOrderChcktPg, 60);
            ButtonCompleteOrderChcktPg.Click();

            return this;
        }
    }
}
