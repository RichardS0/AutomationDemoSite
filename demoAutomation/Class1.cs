using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace demoAutomation
{
    internal class Class1
    {
        public IWebDriver driver;

        public void ElementosDemoAutomation()
        {
            IWebElement lblFullName = driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/label"));
            IWebElement txtFirstName = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input"));
            IWebElement txtLastName = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));

            IWebElement lblAddress = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > label"));
            IWebElement txtAddress = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea"));

            IWebElement lblEmailAddress = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(3) > label"));
            IWebElement txtEmailAddress = driver.FindElement(By.CssSelector("#eid > input"));

            IWebElement lblPhone = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > label"));
            IWebElement txtPhone = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));

            IWebElement lblGender = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > label"));
            IWebElement chkMaleGender = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > div > label:nth-child(1) > input"));
            IWebElement chkFemaleGender = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > div > label:nth-child(2) > input"));

            IWebElement lblHobbies = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(6) > label"));
            IWebElement chkCricketHobbies = driver.FindElement(By.Id("checkbox1"));
            IWebElement chkMoviesHobbies = driver.FindElement(By.Id("checkbox2"));
            IWebElement chkHockeyHobbies = driver.FindElement(By.Id("checkbox3"));

            IWebElement lblSkills = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(8) > label"));
            IWebElement drpSkills = driver.FindElement(By.Id("Skills"));

            IWebElement lblCountry = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(9) > label"));

            IWebElement lblSelCountry = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(10) > label"));
            IWebElement slcSelCountry = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(10) > div > span > span.selection > span > span.select2-selection__arrow"));
            IWebElement cmbCountry = driver.FindElement(By.Id("country"));

            IWebElement lblBirthDate = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(11) > label"));
            IWebElement slcYear = driver.FindElement(By.Id("yearbox"));
            IWebElement slcMonth = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(11) > div:nth-child(3) > select"));
            IWebElement slcDay = driver.FindElement(By.Id("daybox"));

            IWebElement lblPassword = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(12) > label"));
            IWebElement txtPassword = driver.FindElement(By.Id("firstpassword"));

            IWebElement lblConfirmPassword = driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(13) > label"));
            IWebElement txtConfirmPassword = driver.FindElement(By.Id("secondpassword"));

            IWebElement btnUploadFile = driver.FindElement(By.Id("imagesrc"));

            IWebElement btnConfirm = driver.FindElement(By.Id("Button1"));

        }
    }
}
