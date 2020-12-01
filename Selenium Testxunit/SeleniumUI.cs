using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography;
using System.Threading;
using Xunit;

namespace BSH.MES.Media.SeleniumUITest
{
    public class SeleniumUI
    {
        IWebDriver driver = new ChromeDriver();
        [Fact]
        public void OpenURL()
        {
            //Arrange

            driver.Navigate().GoToUrl("http://int.gdc.mes.bshg.com/media-library");
            Thread.Sleep(2500);
            driver.FindElement(By.Id("username")).SendKeys("kuruba");
            driver.FindElement(By.Id("password")).SendKeys("Welcome@10");

            // Act

            driver.FindElement(By.Id("kc-login")).Click();
            //driver.FindElement(By.Id("Filters&nbsp;&nbsp;")).Click();
            Thread.Sleep(2500);

            //IAlert alert = driver.SwitchTo().Alert();
            //Assert.IsType(Loginfail.Title,"Logged In");
            Assert.NotNull("loginSuccessfully");

            driver.Quit();
        }
    }
}
