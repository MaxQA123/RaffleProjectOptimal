using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.AdminSitePages.CmsLogInPage
{
    public partial class CmsLogIn
    {
        public CmsLogIn EnterEmailPasswordCms(string cmsemail, string cmspassword)
        {
            WaitUntil.ElementIsClicable(CmsInputFieldEmail, 3);
            CmsInputFieldEmail.Clear();
            CmsInputFieldEmail.SendKeys(cmsemail);
            WaitUntil.WaitSomeInterval(1);
            CmsInputFieldPassword.Clear();
            CmsInputFieldPassword.SendKeys(cmspassword);

            return this;
        }

        public CmsLogIn ClickSigninButton()
        {
            WaitUntil.ElementIsClicable(CmsButtonSignIn);

            CmsButtonSignIn.Click();

            return this;
        }
    }
}
