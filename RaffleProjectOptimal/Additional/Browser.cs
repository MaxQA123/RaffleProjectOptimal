﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace RaffleProjectOptimal.Additional
{
    public class Browser
    {
        public IWebDriver WebDriver { get; set; }

        public static IWebDriver _webDriver;

        public Browser(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public static void Initialize()
        {
            AllureConfigFilesHelper.CopyJsonConfigFile();

            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
            _Driver.Manage().Cookies.DeleteAllCookies();
            _Driver.Manage().Window.Maximize();

            Assert.NotNull(_webDriver);
        }


        public static string RootPath()
        {
            string mainpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            return mainpath;
        }
        public static ISearchContext Driver { get { return _webDriver; } }
        public static IWebDriver _Driver { get { return _webDriver; } }
        public static string Title
        {
            get { return _webDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return _webDriver.Url; }
        }

        public static void Close()
        {
            _webDriver.Close();
        }

        public static void Quit()
        {
            _webDriver.Quit();
        }
    }
}