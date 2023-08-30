using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo3SignUp
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.Facebook.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Create new account")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys("shanth");
            driver.FindElement(By.Name("lastname")).SendKeys("kumar");
            driver.FindElement(By.Id("password_step_input")).SendKeys("shanthuiyiuy786876");
            driver.FindElement(By.Name("sex")).Click();

        }
    }
}
