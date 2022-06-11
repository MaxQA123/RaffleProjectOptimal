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
            Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.WaitSomeInterval(2);
            LinkResetPasswordXtroo.Click();
            WaitUntil.WaitSomeInterval(1);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[0]);
            Browser._Driver.Close();
            Browser._Driver.SwitchTo().Window(tabsList[1]);

            return this;
        }
    }
}