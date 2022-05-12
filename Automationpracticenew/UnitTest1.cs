using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Automationpracticenew
{
    partial  class Tests : WebDriver
    {

        private string URL = "http://automationpractice.com/index.php";

        //signin data
        
        string reg_email = "newtest65@test.com";
        string reg_email_registered = "testuser_newtest@test.com";

        //registration data
        string reg_first_name = "Neil";
        string reg_last_name = "Peterson";
        string reg_password = "Hello123";
        string reg_address = "Sunstreet23";
        string reg_city = "Homer";
        string reg_post_code = "12345";
        string reg_mobile_phone = "888999333";

        //search data
        string search_item = "dress";


        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(URL);
        }

        [Test]
        public void SigninTest()
        {
            SignInActions();
            IWebElement logout_btn = Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(2) > a"));
            Assert.IsTrue(logout_btn.Displayed);
        }

   

        [Test]
        public void LoginTest()
        {
            SignInActions();

            LoginPage loginPage = new LoginPage();
            loginPage.EnterCredentialsAndLogin(reg_email_registered, reg_password);
            IWebElement personal_information = Driver.FindElement(By.ClassName("page-heading"));
            string txt = personal_information.Text;
            Assert.AreEqual(txt, "MY ACCOUNT", "No personal information found");
        }

        [Test]

        public void SearchTest()
        {
            IWebElement search_item_txt = Driver.FindElement(By.Id("search_query_top"));
            search_item_txt.SendKeys(search_item);
            IWebElement searchfield_btn = Driver.FindElement(By.CssSelector("#searchbox > button"));
            searchfield_btn.Click();

            IWebElement dress = Driver.FindElement(By.CssSelector("#center_column > h1 > span.lighter"));
            string txt = dress.Text;
            Assert.AreEqual(txt, "\"DRESS\"", "No dress found");
        }


        [Test]
        public void RegistrationPageTest()
        {
            HomePage homePage = new HomePage();
            homePage.GoToSigninPage();
            SigninPage signinPage = new SigninPage();
            signinPage.EnterCredentialsAndSignin(reg_email);
            RegistrationActions();
            IWebElement logout_btn = Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(2) > a"));
            Assert.IsTrue(logout_btn.Displayed);

        }



        [Test]
        public void SearchAndBuyItemTest()
        {

            SignInActions();

            LoginPage loginPage = new LoginPage();
            loginPage.EnterCredentialsAndLogin(reg_email_registered, reg_password);

            SearchAndBuy SearchAndBuy = new SearchAndBuy();
            SearchAndBuy.EnterItemAndFind(search_item);

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(By.CssSelector("#searchbox > button")).Displayed);
            IWebElement search_btn = Driver.FindElement(By.CssSelector("#searchbox > button"));
            search_btn.Click();
            IWebElement add_to_cart_btn = Driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(1) > div > div.right-block > div.button-container > a.button.ajax_add_to_cart_button.btn.btn-default > span"));
            add_to_cart_btn.Click();

            var wait1 = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait1.Until(drv => drv.FindElement(By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > a")).Displayed);
            IWebElement proceed_btn = Driver.FindElement(By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > a"));      
            proceed_btn.Click();

            IWebElement proceed2_btn = Driver.FindElement(By.CssSelector("#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium > span"));
            proceed2_btn.Click();

            IWebElement proceed_address_btn = Driver.FindElement(By.CssSelector("#center_column > form > p > button > span"));
            proceed_address_btn.Click();

            IWebElement terms_btn = Driver.FindElement(By.CssSelector("#cgv"));
            terms_btn.Click();

            IWebElement proceed_shipping_btn = Driver.FindElement(By.CssSelector("#form > p > button > span"));
            proceed_shipping_btn.Click();

            IWebElement pay_by_bank_btn = Driver.FindElement(By.ClassName("bankwire"));
            pay_by_bank_btn.Click();

            IWebElement confirmation_btn = Driver.FindElement(By.CssSelector("#cart_navigation > button > span"));
            confirmation_btn.Click();

            IWebElement complete_order = Driver.FindElement(By.CssSelector("#center_column > div > p > strong"));
            string txt = complete_order.Text;
            Assert.AreEqual(txt, "Your order on My Store is complete.", "Order is not completed");



        }

        //[TearDown]
        //public void Close()
        //{
        //    Driver.Close();
        //}
    }
}