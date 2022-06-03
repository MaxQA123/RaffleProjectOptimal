using OpenQA.Selenium;
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
        public IWebElement ChangeTicketsInBasket => Browser._Driver.FindElement(_changeTicketsInBasket);
        public readonly static By _changeTicketsInBasket = By.XPath("//div[@class = 'your-basket-total-tickets-container']//button[@class = 'your-basket-ticket-select']");

        public IWebElement ButtonCheckoutNowOnBasket => Browser._Driver.FindElement(_buttonCheckoutNowOnBasket);
        public readonly static By _buttonCheckoutNowOnBasket = By.XPath("//div[@class = 'itemPrice']//button[@class = 'rafflebtn primary full-width']");

    }
}