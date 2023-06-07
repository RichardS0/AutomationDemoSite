using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.WebRequestMethods;

namespace Curso
{
    public class Tests
    {
        public IWebDriver driver;
        public string baseURL;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com.br/";
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("APjFqb")).SendKeys("DevMedia");
            
            driver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.FPdoLc.lJ9FBc > center > input.gNO89b")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div > div > div.yuRUbf > a > h3")).Click();
            
        }
    }
}