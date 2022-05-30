using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.PageObjects.SignUpPage
{
    public partial class SignUp
    {
        public SignUp EnterDataSignUp()
        {
            FirstNameInputField.SendKeys("Bruce");
            LastNameInputField.SendKeys("Lee");
            EmailInputField.SendKeys("ahfgd123dgcvcg" + NameDomen.XItroo);
            PhoneNumInutField.SendKeys("961234563");
            PasswordInputField.SendKeys("Qwerty123!");
            IamCheckBox.Click();
            OptInCheckBox.Click();
            RememberMeCheckBox.Click();
            SignUpButton.Click();

            return this;
        }
    }
}
