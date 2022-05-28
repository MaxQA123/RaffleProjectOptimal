using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.Header
{
    public partial class Header
    {
        public Header OpenSignInPage()
        {
            WaitUntil.ElementIsClicable(_SignInBtn);
            _SignInBtn().Click;

            return this;
        }
    }
}
