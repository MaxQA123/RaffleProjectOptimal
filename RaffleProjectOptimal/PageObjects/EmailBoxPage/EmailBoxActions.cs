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
        public EmailBox OpenNewLetterResetPassword()
        {
            WaitUntil.ElementVisibleAndClickable(By.XPath("//th[text() = '1']"));
            SelectLetterNumberOneNew.Click();

            return this;
        }

        public EmailBox ClickLinkResetPassword()
        {
            WaitUntil.WaitSomeInterval(5);
            Browser._Driver.SwitchTo().Frame(Iframe);
            WaitUntil.WaitSomeInterval(2);
            LinkResetPasswordXtroo.Click();
            Browser._Driver.SwitchTo().DefaultContent();

            return this;
        }
    }
}