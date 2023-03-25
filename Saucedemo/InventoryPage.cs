using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saucedemo
{
    internal class InventoryPage : BasePage
    {
        By product0 = By.Id("item_0_title_link");
        By product1 = By.Id("item_1_title_link");
        By product2 = By.Id("item_2_title_link");
        By product3 = By.Id("item_3_title_link");   
        By product4 = By.Id("item_4_title_link");
        By product5 = By.Id("item_5_title_link");
        By shoppingcart = By.Id("shopping_cart_container");
        By checkout = By.Id("checkout");
        public void Inventory()
        {
            Product0();
            Product1(); 
            Product2(); 
            Product3();
            Product4();
            Product5();
        }
        public void Product4() //done
        {
            driver.Url = "https://www.saucedemo.com/inventory.html";
            driver.FindElement(product4).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(shoppingcart).Click();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/cart.html");
            driver.FindElement(By.Id("checkout")).Click();
        }
            
        public void Product0() //done
        {
            driver.Url = "https://www.saucedemo.com/inventory.html";
            driver.FindElement(product0).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();            
            driver.FindElement(shoppingcart).Click();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/cart.html");
            driver.FindElement(By.Id("checkout")).Click();
        }
         
        public void Product1() //done
        {
            driver.Url = "https://www.saucedemo.com/inventory.html";
            driver.FindElement(product1).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click(); 
            driver.FindElement(shoppingcart).Click();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/cart.html");
            driver.FindElement(By.Id("checkout")).Click();
        } 
        public void Product2() //done
        {
            driver.Url = "https://www.saucedemo.com/inventory.html";
            driver.FindElement(product2).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click(); 
            driver.FindElement(shoppingcart).Click();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/cart.html");
            driver.FindElement(By.Id("checkout")).Click();
        } 
        public void Product3() // done
        {
            driver.Url = "https://www.saucedemo.com/inventory.html";
            driver.FindElement(product3).Click();
            driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            driver.FindElement(shoppingcart).Click();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/cart.html");
            driver.FindElement(By.Id("checkout")).Click();
        } 
        public void Product5() // done
        {
            driver.Url = "https://www.saucedemo.com/inventory.html";
            driver.FindElement(product5).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            driver.FindElement(shoppingcart).Click();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/cart.html");
            driver.FindElement(By.Id("checkout")).Click();
        }
        
    }
}
