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
        public IWebElement Iframe => Browser._Driver.FindElement(_Iframe);
        public readonly static By _Iframe = By.XPath(" //iframe[@title='Secure payment frame - Gr4vy']");
        public IWebElement FieldInputCardNumber => Browser._Driver.FindElement(_fieldInputCardNumber);
        public readonly static By _fieldInputCardNumber = By.XPath("//*[@id = 'card-number']");

        public IWebElement FieldExpirationDate => Browser._Driver.FindElement(_fieldInputExpirationDate);
        public readonly static By _fieldInputExpirationDate = By.XPath("//div/input[@id = 'card-expiration-date']");

        public IWebElement FieldInputCvv => Browser._Driver.FindElement(_fieldInputCvv);
        public readonly static By _fieldInputCvv = By.XPath("//div/input[@id = 'card-security-code']");

        public IWebElement ButtonCompleteOrderChcktPg => Browser._Driver.FindElement(_buttonCompleteOrderChcktPg);
        public readonly static By _buttonCompleteOrderChcktPg = By.XPath("");
    }
}
