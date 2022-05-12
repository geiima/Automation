using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automationpracticenew
{
    partial class Tests : WebDriver
    {
        private void SignInActions()
        {
            HomePage homePage = new HomePage();
            homePage.GoToSigninPage();
            SigninPage signinPage = new SigninPage();
            signinPage.EnterCredentialsAndSignin(reg_email);
        }

        private void RegistrationActions()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(drv => drv.FindElement(By.Id("customer_firstname")).Displayed);

            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.FillFormAndRegister(reg_first_name, reg_last_name, reg_password, reg_address, reg_city, reg_post_code, reg_mobile_phone);
            registrationPage.SelectDropdown();
            IWebElement register_btn = Driver.FindElement(By.CssSelector("#submitAccount > span"));
            register_btn.Click();
        }
    }
}
