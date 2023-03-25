using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Saucedemo
{
    internal class Filteraition:BasePage
    {
        By username = By.Id("user-name");
        By password = By.Id("password");
        public void Filtermethod()
        {

            driver.Url = "https://www.saucedemo.com/";

            driver.FindElement(username).SendKeys("standard_user");
            driver.FindElement(password).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            var element = driver.FindElement(By.ClassName("product_sort_container")); 
            var filter = new SelectElement(element);
            filter.SelectByValue("az");
        }
    }
    
}
