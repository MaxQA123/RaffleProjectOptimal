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
    public class BaseWeb
    {

        [OneTimeSetUp]
        public void DobeforeAllTheTests()
        {
            Browser.Initialize();
        }

        [OneTimeTearDown]
        public void DoAfterAllTheTests()
        {

        }

        [TearDown]

        public void DoAfterEach()
        {
            Browser.Quit();
        }

    }
}