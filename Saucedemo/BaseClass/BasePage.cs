using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using AventStack.ExtentReports.Model;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.RightsManagement;

namespace Saucedemo
{
    internal class BasePage
    {
        public static IWebDriver driver;

        public static void SeleniumInit()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            driver = chromeDriver;
        }
        public static void Write(By by, string text)
        {
            driver.FindElement(by).SendKeys(text);
        }

        public static void Screenshot(string filename)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@".\\"+filename+".png", ScreenshotImageFormat.Png);
        }
    }
}
