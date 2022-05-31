using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects
{
    public partial class Header
    {
        public Header OpenSignInPage()
        {
            WaitUntil.ElementIsClicable(buttonSignIn);
            buttonSignIn.Click();

            return this;
        }
        public Header OpenSignUpPage()
        {
            WaitUntil.ElementIsClicable(ButtonSignUp);
            ButtonSignUp.Click();

            return this;
        }
        public Header OpenDrpDwnLiveCompetions()
        {
            WaitUntil.ElementIsClicable(LiveCompetionDrpDwn);
            LiveCompetionDrpDwn.Click();

            return this;
        }
        public Header OpenDreamHomePageViaDrpDwnLiveComp()
        {
            WaitUntil.VisibilityOfAllElementsLocatedBy(_dreamHomeDrpDwnLiveComp);
            DreamHomeDrpDwnLiveComp.Click();

            return this;
        }
    }
}
