using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleProjectOptimal.Additional
{
    public class WebBaseTests
    {
        public IWebDriver _webDriver;

        [OneTimeSetUp]
        public void DobeforeAllTheTests()
        {
            _webDriver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void DoAfterAllTheTests()
        {

        }

        [TearDown]

        public void DoAfterEach()
        {
            _webDriver.Quit();
        }

        [SetUp]
        public void DoBeforeEach()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Navigate().GoToUrl(EndPoints.homePage);
            _webDriver.Manage().Window.Maximize();
        }

    }
}
