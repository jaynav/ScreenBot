﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using screen_crawler.BUtility;

namespace screen_crawler.BSocial
{
   class BrowserbotLinkedin :TextGen
    {
      

        internal static void Run(IWebDriver startSearch, string uName, string uPass, int derValue)
        {
           
            IWebDriver searchStart = BBotUtility.LogMeIn(startSearch, uName, uPass, derValue);
            //
            IWebElement findme;
            startSearch.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20.0));
            findme = searchStart.FindElement(By.Name("postText"));
            findme.Click();
            findme.SendKeys("hello li9nkedin");
            Thread.Sleep(1000);// change this to implicitly wait
            findme = searchStart.FindElement(By.Id("share-submit"));
            findme.Click();
        }

       
    }
}
