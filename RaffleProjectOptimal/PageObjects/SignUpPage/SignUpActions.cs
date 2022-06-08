using RaffleProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RimuTec.Faker;

namespace RaffleProjectOptimal.PageObjects.SignUpPage
{
    public partial class SignUp
    {
        public SignUp EnterDataSignUp()
        {
            WaitUntil.ElementIsClicable(FirstNameInputField, 8);

            FirstNameInputField.SendKeys(Name.FirstName());
            LastNameInputField.SendKeys(Name.LastName());
            EmailInputField.Clear();
            EmailInputField.SendKeys(RandomGenerateData.RandomString() + NameDomen.XItroo);
            PhoneNumInutField.SendKeys("1132345631");
            PasswordInputField.SendKeys("Qwerty123!");
            IamCheckBox.Click();            
            OptInCheckBox.Click();
            RememberMeCheckBox.Click();

            return this;
        }
        public SignUp ClickSignUpBtn()
        {
            SignUpButton.Click();

            return this;
        }
    }
}