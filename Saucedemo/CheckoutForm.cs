using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo
{
    internal class CheckoutForm : BasePage
    {
        By fname = By.Id("first-name");
        By lname = By.Id("last-name");
        By zip = By.Id("postal-code");
        By cont = By.Id("continue");
        By finish = By.Id("finish");
        By backhome= By.Id("back-to-products");

        public void Checkout()
        {
            driver.FindElement(fname).SendKeys("user");
            driver.FindElement(lname).SendKeys("here");
            driver.FindElement(zip).SendKeys("1234");
            driver.FindElement(cont).Click();
            driver.FindElement(finish).Click();
            driver.FindElement(backhome).Click();
        }
    }
}
