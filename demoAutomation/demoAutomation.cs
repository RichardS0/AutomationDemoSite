using System;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace demoAutomation
{
    public class Tests
    {
        public IWebDriver driver;
        public string baseURL;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
            baseURL = "https://demo.automationtesting.in/Register.html";
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl(baseURL);
            if (driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/label")).Text == "Full Name*")
            {
                driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input")).SendKeys("João");
                driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input")).SendKeys("da Silva");
            }

            if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > label")).Text == "Address")
            {
                driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea")).SendKeys("Rua Ortelina Dourado Brandao");
            }

            if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(3) > label")).Displayed && (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(3) > label")).Text == "Email address*"))
            {
                driver.FindElement(By.CssSelector("#eid > input")).SendKeys("antonio_jesus@robiel.com.br");
            }

            if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > label")).Text == "Phone*")
            {
                driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input")).SendKeys("1986844636");
            }

            if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > label")).Text == "Gender*")
            {
                driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > div > label:nth-child(1) > input")).Click();
                driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > div > label:nth-child(2) > input")).Click();
            }

            if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(6) > label")).Text == "Hobbies" && !driver.FindElement(By.Id("checkbox1")).Selected)
            {
                driver.FindElement(By.Id("checkbox1")).Click();
                driver.FindElement(By.Id("checkbox2")).Click();
                driver.FindElement(By.Id("checkbox3")).Click();
            }

            /*if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(7) > div > multi-select")).Displayed)
            {
                driver.FindElement(By.Id("msdd")).Click();
                SelectElement languages = new SelectElement(driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(7) > div > multi-select > div:nth-child(2) > ul")));
                string lingua = "Arabic";
                languages.SelectByValue(lingua);
            }
            */

            if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(8) > label")).Text == "Skills")
            {
                
                SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("Skills")));
                string opcao = "Backup Management";
                dropdown.SelectByValue(opcao);
            }

            if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(9) > label")).Text == "Country*")
            {
                Assert.IsTrue(driver.FindElement(By.CssSelector("#countries > option")).Text == "Select Country");
            }

            Thread.Sleep(10000);

            if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(10) > label")).Text == "Select Country :")
            {
                driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(10) > div > span > span.selection > span > span.select2-selection__arrow")).Click();
                SelectElement comboBox = new SelectElement(driver.FindElement(By.Id("country")));
                comboBox.SelectByValue("Bangladesh");
                driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(10) > div > span > span.selection > span > span.select2-selection__arrow")).Click();
            }

            if (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(11) > label")).Text == "Date Of Birth")
            {
                SelectElement ano = new SelectElement(driver.FindElement(By.Id("yearbox")));
                ano.SelectByText("1997");

                SelectElement mes = new SelectElement(driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(11) > div:nth-child(3) > select")));
                mes.SelectByText("February");

                SelectElement dia = new SelectElement(driver.FindElement(By.Id("daybox")));
                dia.SelectByText("11");
            }

            if ((driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(12) > label")).Text == "Password") & 
                 (driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(13) > label")).Text == "Confirm Password"))
            {
               driver.FindElement(By.Id("firstpassword")).SendKeys("password");
               driver.FindElement(By.Id("secondpassword")).SendKeys("password");
            }

            driver.FindElement(By.Id("imagesrc")).SendKeys("C:\\Users\\Richard\\Pictures\\teste-palavra-25488843.jpg");

            driver.FindElement(By.Id("Button1")).Click();
        }
    }
}