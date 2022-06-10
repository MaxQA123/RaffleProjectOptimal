using OpenQA.Selenium;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.EmailBoxPage
{
    public partial class EmailBox
    {
        public IWebElement SelectLetterNumberOneNew => Browser._Driver.FindElement(_SelectLetterNumberOneNew);
        public readonly static By _SelectLetterNumberOneNew = By.XPath("//th[text() = '1']");

        public IWebElement Iframe => Browser._Driver.FindElement(_Iframe);
        public readonly static By _Iframe = By.XPath("//iframe[@id = 'mailContentFrame']");

        public IWebElement LinkResetPasswordXtroo => Browser._Driver.FindElement(_LinkResetPasswordXtroo);
        public readonly static By _LinkResetPasswordXtroo = By.XPath("//div[@id = 'frameContent']//a");
   
    }
}
