using NUnit.Framework;
using OpenQA.Selenium;
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
        public static string GetEmail()
        {
            string getEmail = Browser._Driver.FindElement(By.XPath("//input[@name ='email']")).GetAttribute("value");
            string email = getEmail.ToString();

            return email;
        }
        public SignUp VerifyEmail(string email)
        {
            WaitUntil.VisibilityOfAllElementsLocatedBy(By.XPath("//h1[text() = 'My Details']"));
            string emailFld = EmailInputField.GetAttribute("value");

            Assert.AreEqual(emailFld, emailFld);

            return this;
        }
    }
}