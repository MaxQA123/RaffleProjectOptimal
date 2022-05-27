using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using NUnit.Allure.Attributes;
using Allure.Commons;

namespace RaffleProjectOptimal.Additional
{
    internal class AllureServe
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("WebSite")]
        [AllureSubSuite("Client")]


        public void GoToAllureResults()
        {
            AllureConfigFilesHelper.CreateBatFile();
            Process.Start(Browser.RootPath() + "allure serve.bat");
        }
    }
}
