using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace OnlineShop2022Tests
{
    [TestFixture]
    public class Tests
    { 
        IWebDriver driver = new FirefoxDriver();

        [Test]
        public void TestMethod()
        {
            this.driver.Navigate().GoToUrl(@"https://localhost:44306/Identity/Account/Login?ReturnUrl=%2F");
            IWebElement element = driver.FindElement(By.Name("provider"));
            element.Click();
        }
        
    }
}