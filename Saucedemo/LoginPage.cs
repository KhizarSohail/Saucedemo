using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo
{
    internal class LoginPage : BasePage
    {
        By username = By.Id("user-name");
        By password = By.Id("password");
        public void Login_Access()
        {
            
            driver.Url = "https://www.saucedemo.com/";
            driver.FindElement(username).SendKeys("standard_user");
            driver.FindElement(password).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            string text = "Products";
            string message = driver.FindElement(By.ClassName("title")).Text;
            Assert.AreEqual(message, text);

        }
    }
}
