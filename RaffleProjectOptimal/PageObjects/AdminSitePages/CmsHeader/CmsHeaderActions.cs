using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.AdminSitePages.CmsHeader
{
    public partial class CmsHeader
    {
        public CmsHeader OpenProfile()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClicable(IconProfile);
            IconProfile.Click();
            ButtonProfile.Click();

            return this;
        }
    }
}
