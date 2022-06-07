using NUnit.Framework;
using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleAdminSite
{
    
    public class AdminBase : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser._Driver.Navigate().GoToUrl(EndPoints.CmsLogInPage);
        }

    }
}
   
