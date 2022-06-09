using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.Additional
{
    public class Button
    {
        // Для выбора приза
        public static void ClickEnterButtonWeekly(string titlePrize)
        {
            WaitUntil.WaitSomeInterval(2);

            IWebElement enterButton = Browser._Driver.FindElement(By.XPath($"//h3[contains(text(), '{titlePrize}')]/ancestor::article/div/button"));

            enterButton.SendKeys("");
            WaitUntil.WaitSomeInterval(2);
            enterButton.Click();
        }
        public static void ClickEnterButtonDream(string titlePrize)
        {
            WaitUntil.WaitSomeInterval(2);

            IWebElement enterButton = Browser._Driver.FindElement(By.XPath($"//button[text() = '{titlePrize}']/ancestor::div/button"));

            enterButton.SendKeys("");
            WaitUntil.WaitSomeInterval(2);
            enterButton.Click();
        }
        public static void ClickEnterButtonFixed(string titlePrize)
        {
            WaitUntil.WaitSomeInterval(2);

            IWebElement enterButton = Browser._Driver.FindElement(By.XPath($"//button[text() = '{titlePrize}']/ancestor::article/div/button"));

            enterButton.SendKeys("");
            WaitUntil.WaitSomeInterval(2);
            enterButton.Click();
        }
        public static void InputFunction(string text, IWebElement element)
        {
            WaitUntil.ElementIsClicable(element);

            element.Clear();
            element.SendKeys(text);
        }
    }

    public class Input
    {
        public static void InputFunction(IWebElement element, string text)
        {
            WaitUntil.ElementIsClicable(element);

            element.Clear();
            element.SendKeys(text);
        }

    }
}
