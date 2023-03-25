using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing.Imaging;
using System.Net.PeerToPeer;

namespace Saucedemo
{
    [TestClass]
    public class UnitTest1
    {

        #region Logger
        private static readonly log4net.ILog log = 
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Class Instances & Variables
        LoginPage login = new LoginPage();
        InventoryPage inventory = new InventoryPage();
        CheckoutForm checkoutForm = new CheckoutForm(); 
        Filteraition filtermodule = new Filteraition();
        #endregion

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }

        [TestInitialize]
        public void TestInit()
        {
            BasePage.SeleniumInit();
        }
        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.driver.Close();
        }

        [TestMethod, TestCategory("Login")]
        public void Login_ValidInput_SuccessfulLogin()
        {
            login.Login_Access();
        }

        [TestMethod, TestCategory("inventory")]
        public void Inventory_ValidInput_Success()
        {
            login.Login_Access();
            inventory.Inventory();
        }

        [TestMethod, TestCategory("Checkout")]
        public void Checkout_ValidInput_Success()
        {
            login.Login_Access();
            inventory.Inventory();
            checkoutForm.Checkout();
        }
        
    }
}
